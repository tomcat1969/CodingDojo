//         01234567
var str = "bbbcdde"
//          s
//             f

function encodeStr(str){

    var s = 0;
    var newstr = "";
    var count = 1;
    
    for(var f = 1; f <= str.length;f++ ){
        if(str[f] == str[s]){
            count++;           
            continue;
        }else{
            newstr += str[s]
            if(count > 1){
                newstr += count;
            }
                count = 1;           
            s = f

        }


    }

    return newstr;
}

console.log(encodeStr(str))

