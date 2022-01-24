jQuery(document).ready(function () {

    var tableActors = $('#actors-table').DataTable();
    var tablePersonnel = $('#peraonnel-table').DataTable();

    $('#actors-table tbody').on('click', 'tr', function () {
        $(this).toggleClass('selected');
    });

    $('#peraonnel-table tbody').on('click', 'tr', function () {
        $(this).toggleClass('selected');
    });

    $('#button-add-actors').click(function () {

        var selectedActors = tableActors.rows('.selected').data();
        var selectedActorsHTML = document.getElementById('selected-actors');

        for (let i = 0; i < selectedActors.length; i++) {

            let firstName = selectedActors[i][2];
            let lastName = selectedActors[i][3];
            let image = selectedActors[i][1].split('src=')[1].split(/[ >]/)[0];
            let id = selectedActors[i][4].trim();

            selectedActorsHTML.appendChild(createSelectedActorCard(firstName, lastName, image, parseInt(id), i));

        }

    });

    $('#button-add-personnel').click(function () {
        alert('klik');
        var selectedPersonnel = tablePersonnel.rows('.selected').data();
        var selectedPersonnelHTML = document.getElementById('selected-personnel');

        for (let i = 0; i < selectedPersonnel.length; i++) {

            let firstName = selectedPersonnel[i][2];
            let lastName = selectedPersonnel[i][3];
            let image = selectedPersonnel[i][1].split('src=')[1].split(/[ >]/)[0];
            let id = selectedPersonnel[i][4].trim();

            selectedPersonnelHTML.appendChild(createSelectedPersonnelCard(firstName, lastName, image, parseInt(id), i));

        }

    });

});


function createSelectedActorCard(firstName, lastName, image, id, i) {

    let div = document.createElement("div");
    div.classList.add('card');
    div.classList.add('mb-3');
    div.style.maxWidth = "540px"

    let html = '<div class="row no-gutters" >' +
                    '<div class="col-md-4">' +
                        '<img src=' + image + ' class="card-img">' +
                    '</div>' +
                    '<div class="col-md-8">' +
                        '<div class="card-body">' +
                            '<h5 class="card-title">' + firstName + lastName + '</h5>' +
                            '<input type="hidden" name="Actings[' + i + '].ActorId" value="' + id + '" />' +
                            '<label for="fname">Role:</label>' +
                            '<input type="text" id="fname" name="Actings[' + i + '].Role"><br><br>' +
                            '<label for="fname">Income:</label>' +
                            '<input type="text" id="fname" name="Actings[' + i + '].Income"><br><br>' +
                        '</div>' +
                    '</div>' +
                '</div>';

    div.innerHTML = html;
  
    return div;

}


function createSelectedPersonnelCard(firstName, lastName, image, id, i) {

    let div = document.createElement("div");
    div.classList.add('card');
    div.classList.add('mb-3');
    div.style.maxWidth = "540px"

    let html = '<div class="row no-gutters" >' +
                    '<div class="col-md-4">' +
                    '<img src=' + image + ' class="card-img">' +
                    '</div>' +
                    '<div class="col-md-8">' +
                        '<div class="card-body">' +
                        '<h5 class="card-title">' + firstName + lastName + '</h5>' +
                        '<input type="hidden" name="Positions[' + i + '].PersonnelId" value="' + id + '" />' +
                        '<label for="fname">Position</label>' +
                        '<input type="text" id="fname" name="Positions[' + i + '].PositionTitle"><br><br>' +
                        '</div>' +
                    '</div>' +
                '</div>';

    div.innerHTML = html;

    return div;

}

