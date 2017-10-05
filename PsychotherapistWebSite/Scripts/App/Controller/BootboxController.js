var BootboxController = function() {
    var save = function(location) {
        return {
            size: "small",
            buttons: {
                ok: {
                    label: "Tamam",
                    className: "btn btn-success"
                }
            },
            message: "Güncellendi.",
            callback: function () {
                window.location.href = location;
            }
        }
    };

    var del = function(id) {
        return {
            size: "small",
            buttons: {
                confirm: {
                    label: "Evet",
                    className: "btn btn-danger"
                },
                cancel: {
                    label: "İptal",
                    className: "btn btn-default"
                }
            },
            message: "Silmek istediğinizden emin misiniz?",
            callback: function(result) {
                if (result) {
                    ServiceService.delete(id);
                }
            }
        }
    };

    var add = function(location) {
        return {
            size: "small",
            buttons: {
                ok: {
                    label: "Tamam",
                    className: "btn btn-success"
                }
            },
            message: "Yeni Alan başarı ile eklendi.",
            callback: function () {
                window.location.href = location;
            }
        }
        
    }

    return {
        save: save,
        delete: del,
        add: add
    }
}();