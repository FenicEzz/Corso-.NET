function numLit(number) {

    function to20(number) {
        var values = [
            "", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove",
            "dieci", "undici", "dodici", "tredici", "quattordici", "quindici", "sedici",
            "diciassette", "diciotto", "diciannove"
        ]
        return values[number]
    }

    function to100(number) {
        if (number < 20) return to20(number)
        var values = [, , "venti", "trenta", "quaranta", "cinquanta", "sessanta", "settanta", "ottanta", "novanta"]
        return values[(Math.floor(number / 10))] + to20(number % 10)
    }

    function to1000(number) {
        if (number < 100) return to100(number)
        var values = "cento"
        return to100([Math.floor(number / 100)]) + values + to100(number % 100)
    }

    function to1kk(number) {
        if (number < 1000) return to1000(number)
        var values = "mila"
        return to1000([Math.floor(number / 1000)]) + values + to1000(number % 1000)
    }

    function to1kkk(number) {
        if (number < 1000000) return to1kk(number)
        var values = "milion*"
        return to1kk([Math.floor(number / 1000000)]) + values + to1kk(number % 1000000)
    }

    function to1kkkk(number) {
        if (number < 1000000000) return to1kkk(number)
        var values = "miliard*"
        return to1kkk([Math.floor(number / 1000000000)]) + values + to1kkk(number % 1000000000)
    }

    return to1kkkk(number);
}


for (i = 1111111700; i < 1111111800; i++) {
    console.log(numLit(i));
}