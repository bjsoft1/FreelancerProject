let toastr_options = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": true,
    "progressBar": false,
    "positionClass": "toast-top-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "10000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
}

var notify = {
    Success: (message) => {
        toastr.options = { ...toastr_options };
        toastr["success"](message)
    },

    Info: (message) => {
        toastr.options = {
            ...toastr_options,
            "timeOut": "120000",
            "closeButton": true,
            "extendedTimeOut": "120000"
        };
        toastr["info"](message)
    },

    Error: (message) => {
        toastr.options = {
            ...toastr_options,
            "closeButton": true,
            "timeOut": "600000",
            "extendedTimeOut": "600000"
        }
        toastr["error"](message)
    },

    Warning: (message) => {
        toastr.options = {
            ...toastr_options,
            "closeButton": true,
            "timeOut": "300000",
            "extendedTimeOut": "300000"
        }
        toastr["warning"](message)
    }
}
