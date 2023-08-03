var c1 = $['#codigoP1'].value;
var qtd1 = $['#qtdP1'].value;
var vn1 = $['#vnP1'].value;
var c2 = $['#codigoP1'].value;
var qtd2 = $['#qtdP2'].value;
var vn2 = $['#vnP2'].value;

$['#sub'].click(function(){
    $['#res'].append((qtd1 * c1) + (qtd2 * c2));
})
