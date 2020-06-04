<template>
    <div>
        <div class="page-title">
            <h3>Сотрудники</h3>
        </div>

        <div class="users-chart">
            <canvas ref="canvas"></canvas>
        </div>

        <Loader v-if="loading" />

        <div v-else class="row">
        </div>
    </div>
</template>
<script>
    import { Pie } from 'vue-chartjs'
    import DocsMixin from '../mixins/docs.mixin.js'
    export default {
        mixins: [DocsMixin],
        data: () => ({
            loading: true,
            dataList: []
        }),
        metaInfo() {
            return {
                title: 'Сотрудники'
            }
        },
        extends: Pie,
        async mounted() {
            this.dataList = await this.getDocsList()
            this.setupChart(this.$store.getters.users)
            this.loading = false
        },
        methods: {
            setupChart(userList) {
                let userListValues = Object.values(userList)
                let userCount = userListValues.length
                let dataCount = this.dataList.length
                this.renderChart({
                    labels: userListValues,
                    datasets: [
                        {
                            label: 'Data',
                            data: userListValues.map(name => {
                                return this.dataList.reduce((total, data) => {
                                    if (data.initiatorName === name) total += 1
                                    return total
                                }, 0)
                            }),
                            backgroundColor:
                                Array.from({ length: userCount },
                                    () => 'rgba(' + Math.floor(Math.random() * 256) + ',' +
                                        Math.floor(Math.random() * 256) + ',' +
                                        Math.floor(Math.random() * 256) + ', 0.5)')
                            ,
                            borderColor: Array.from({ length: userCount },
                                () => 'rgba(0, 0, 0, 1)'),
                            borderWidth: 1
                        }
                    ]
                },
                    {
                        responsive: true,
                        maintainAspectRatio: true,
                        tooltips: {
                            callbacks: {
                                label: function (tooltipItem, data) {
                                    return data['labels'][tooltipItem['index']] + ': ' + (Math.round(+ data['datasets'][0]['data'][tooltipItem['index']] / dataCount * 100, 2)) + '%'
                                }
                            }
                        },
                        legend: {
                            position: 'left'
                        }

                    }
                )
            }
        }
    }
</script>