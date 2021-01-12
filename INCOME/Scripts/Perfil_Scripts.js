$(document).ready(function () {
    OpcionesUpdate();
    ObtenerInformacion();
    var username = "Al2435";
    $.ajax({
        url: "ObtenerPerfil",
        method: "GET",
        data: { UserName: username },
        async: false,
        dataType: "html",
        success: function (data) {
            $("#informacion").html(data);
        },
        error: function () {
            console.log("no funciono :c");
        }
    })
});


function OpcionesUpdate(){
    $("#info").click(function () {
        $("#informacion").show();
        $("#changeinformacion").hide();
        $("#contrasena").hide();
        $("#imagen_perfil").hide();
    });

    $("#changeinfor").click(function () {
        $("#informacion").hide();
        $("#changeinformacion").show();
        $("#contrasena").hide();
        $("#imagen_perfil").hide();
    });

    $("#changepassword").click(function () {
        $("#informacion").hide();
        $("#changeinformacion").hide();
        $("#contrasena").show();
        $("#imagen_perfil").hide();
    });

    $("#changeprofile").click(function () {
        $("#informacion").hide();
        $("#changeinformacion").hide();
        $("#contrasena").hide();
        $("#imagen_perfil").show();
    });
}


function ObtenerInformacion() {
    $("#info").click(function () {
        var username = "Al2435";
        $.ajax({
            url: "ObtenerPerfil",
            method: "GET",
            data: { UserName: username },
            async: false,
            dataType: "html",
            success: function (data) {
                $("#informacion").html(data);
            },
            error: function () {
                console.log("no funciono :c");
            }
        })
    });
}