

$(function () {

    var ajaxFormRefresh = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-otf-target"));
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
            $newHtml.effect("highlight");
            $newHtml.find("#stockData tr").each(function () {

                var $col = $(this).find("#priceMovement").html();
                if (typeof ($col) === "undefined")
                {
                }
                else
                {
                    if ($col > 0)
                    {
                        $(this).find("#stockPrice").css("background-color", "green").attr('title', 'Price Increased.')                        
                    }
                    else if ($col < 0)
                    {
                        $(this).find("#stockPrice").css("background-color", "red").attr('title', 'Price Decreased.')
                    }
                    else
                    {
                        $(this).find("#stockPrice").css("background-color", "white").attr('title', 'Price Unchanged.')
                    }
                }

            });
        });

        return false;
    };

    var ajaxKeyPressSearch = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-otf-target"));
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
            $newHtml.effect("highlight");
        });

        return false;
    };

       var getPage = function () {
        var $a = $(this);

        var options = {
            url: $a.attr("href"),
            data: $("form").serialize(),
            type: "get"
        };

        $.ajax(options).done(function (data) {
            var target = $a.parents("div.pagedList").attr("data-otf-target");
            $(target).replaceWith(data);
        });
        return false;

    };
       $("form[data-otf-ajax='true']").submit(ajaxFormRefresh);
       $("form[data-otf-ajax='true']").keyup(ajaxKeyPressSearch);
     

    $(".main-content").on("click", ".pagedList a", getPage);
});