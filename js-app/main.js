const url = "https://localhost:5001/api/beanvariety/";

const button = document.querySelector("#run-button");
button.addEventListener("click", () => {
    getAllBeanVarieties()
        .then(beanVarieties => {
            console.log(beanVarieties);
        })
});

function getAllBeanVarieties() {
    return fetch(url).then(resp => resp.json());
};

const displayBeans = (beans) => {
    const stringBeans = beans.map((bean) => {
        return `
        <div class="beans">
        <p>${bean.name}</p>
        <p>${bean.region}</p>
        <p>${bean.notes}</p>
        </div>`
    }).join("")

    contentTarget.innerHTML = stringBeans
};