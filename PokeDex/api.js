function api(){
    let url = "https://pokeapi.co/api/v2/pokemon/";
    let userInput = document.getElementById("pokemon").value;
    url = url + userInput;

    fetch(url)
        .then(response => response.json())
        .then(data => {
            populateIntoList(data)
        })
        .catch(err => console.log(err))
}

function populateIntoList(fetchedData){
    let list = []
    list.push(fetchedData.sprites["front_default"])
    list.push(fetchedData.forms[0].name)
    for (let i = 0; i < fetchedData.stats.length; i++) {
        list.push(fetchedData.stats[i].stat.name)
        list.push(fetchedData.stats[i].base_stat)
    }
    GenerateList(list)
}

function GenerateList(DataList) {
    let list = document.getElementById("pokeList");
    let div = document.createElement("div");
    let ulList = null;

    for (let i = 0; i < DataList.length; i++) {
        if(i == 0){
            let img = document.createElement("img");
            img.src = DataList[i];
            div.appendChild(img);
            console.log(i);
        }
        if(i == 1){
            let li = document.createElement("li")
            li.innerHTML = DataList[i]
            div.appendChild(li)
            console.log(i)
        }
        if (i % 2 == 0 && i > 1) {
            ulList = document.createElement("ul");
            ulList.id = "ulList" + i;
            let li = document.createElement("li");
            li.innerHTML = DataList[i];
            ulList.appendChild(li);
            div.appendChild(ulList);
            console.log(i);
        } else {
            if (ulList) {
                ulList.firstChild.innerHTML = ulList.firstChild.innerHTML + ": <b>" + DataList[i] + "</b>   "
            }
        }
    }

    list.appendChild(div)
}