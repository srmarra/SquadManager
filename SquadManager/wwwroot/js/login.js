function login() {

    var formData = {
        email: $("#email").val(),
        password: $("#password").val(),
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7053/api/user",
        success: function (result) {
            if (result.response == 'OK') {
                alert("logado")
            } else {
                alert("Credenciais invalidas");
            }
            },
        erro: function (error) {
            console.log(error)
        }

    });
}


