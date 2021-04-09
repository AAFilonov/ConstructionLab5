var app = new Vue({
    el: '#app',
    data: {
        message: 'Hello Vue!'
        ,tariff_flats: [
            { title: 'Квартирный  S', descr: 'Длинное описание тарифа Квартирный S', price: 590 },
            { title: 'Квартирный  M', descr: 'Длинное описание тарифа Квартирный M', price: 990 },
            { title: 'Квартирный  L', descr: 'Длинное описание тарифа Квартирный L', price: 1290 },

        ]

    },
    methods: {
        async initialize() {
            let response = await fetch(`/api/Tariff/getData`, {
                method: 'GET'
            });

            if (response.ok) {

                this.message = await message.json();
                console.log(this.statistics);
            } else console.log('Произошла внутренняя ошибка сервера.'); 
        },
    },
    async mounted() {

        await this.initialize();
    },

});