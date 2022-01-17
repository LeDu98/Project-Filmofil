jQuery(document).ready(function () {

    var table = $('#example').DataTable();

    $('#example tbody').on('click', 'tr', function () {
        $(this).toggleClass('selected');
    });

    $('#button').click(function () {

        var selectedActors = table.rows('.selected').data();
        var selectedActorsHTML = document.getElementById('selected-actors');

        for (let i = 0; i < selectedActors.length; i++) {

            let name = selectedActors[i][2];
            let image = selectedActors[i][1].split('src=')[1].split(/[ >]/)[0];

            selectedActorsHTML.appendChild(createSelectedActorCard(name, image))

        }

        alert(table.rows('.selected').data().length + ' row(s) selected');

    });

});


function createSelectedActorCard(name, image) {

    console.log(image);

    let div = document.createElement("div");
    div.classList.add('card');
    div.classList.add('mb-3');
    div.style.maxWidth = "540px"

    let html = '<div class="row no-gutters" >' +
        '<div class="col-md-4">' +
        '<img src=' + image + ' class="card-img" alt="...">' +
        '</div>' +
        '<div class="col-md-8">' +
        '<div class="card-body">' +
        '<h5 class="card-title">' + name + '</h5>' +
        '<label for="fname">Role:</label>' +
        '<input type="text" id="fname" name="fname"><br><br>' +
        '<label for="fname">Income:</label>' +
        '<input type="text" id="fname" name="fname"><br><br>' +
        '</div>' +
        '</div>' +
        '</div>';


    div.innerHTML = html;
    console.log(html);
    return div;

}