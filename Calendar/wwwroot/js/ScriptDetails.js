const date = new Date();

const renderCalendar = (pDate) =>
{
    date.setDate(1);

    let choosedDate = new Date(date);

    if (typeof (pDate) !== 'undefined')
    {
        choosedDate.setDate(pDate);
    }

    console.log(choosedDate);

    const monthDays = document.querySelector('.days');

    const lastDay = new Date(date.getFullYear(), date.getMonth() + 1, 0).getDate();

    const prevLastDay = new Date(date.getFullYear(), date.getMonth(), 0).getDate();

    const firstDayIndex = date.getDay();

    const lastDayIndex = new Date(date.getFullYear(), date.getMonth() + 1, 0).getDay();

    const nextDays = 7 - lastDayIndex - 1;

    const months =
        [
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        ];

    document.querySelector('.date h1').innerHTML
        = months[date.getMonth()];

    if (typeof (pDate) !== 'undefined')
    {
        document.querySelector('.date p').innerHTML
            = choosedDate.toDateString();
    }
    else if (date.getMonth() !== new Date().getMonth() ||
        date.getYear() !== new Date().getYear()) 
    {
        document.querySelector('.date p').innerHTML
            = date.toDateString();
    }
    else
    {
        document.querySelector('.date p').innerHTML
            = new Date().toDateString();
    }

    let days = "";

    for (let x = firstDayIndex; x > 0; x--) {
        days += `<div class = "prev-date">${prevLastDay - x + 1}</div>`;
    }

    for (let i = 1; i <= lastDay; i++) {
        if (i === new Date().getDate() &&
            date.getMonth() === new Date().getMonth() &&
            date.getYear() === new Date().getYear())
        {
            days += `<div class = "today">${i}</div>`;
        }
        else if (i == pDate)
        {
            days += `<div class = "clicked-date">${i}</div>`;
        }
        else {
            days += `<div>${i}</div>`;
        }
    }


    for (let j = 1; j <= nextDays; j++) {
        days += `<div class = "next-date">${j}</div>`;
    }

    monthDays.innerHTML = days;
}

document.querySelector('.prev').addEventListener('click', () => //Previous month
{
    date.setMonth(date.getMonth() - 1)
    renderCalendar();
})

document.querySelector('.next').addEventListener('click', () => //Next month
{
    date.setMonth(date.getMonth() + 1)
    renderCalendar();
})

document.querySelector('.days').addEventListener('click', (event) => { //Choose Date
    if (event.target !== event.currentTarget)
    {
        if ($(event.target).attr('class') === 'prev-date')
        {
            date.setMonth(date.getMonth() - 1)
        }
        else if ($(event.target).attr('class') === 'next-date')
        {
            date.setMonth(date.getMonth() + 1)
        }
            $(event.target).addClass('clicked-date');
            renderCalendar($(event.target).text());
        
    }
});

//document.querySelector('.days').addEventListener('click', (event) => {
//    if (event.target !== event.currentTarget)
//    {
//        const el = event
//        console.log(event.target);
//    }
//});

//$(document).click(function (event) {
//    console.log($(event.target).text());
//});

renderCalendar();

