using UnityEngine;
using System.Collections;

//É comum criar uma classe para conter todos os seus métodos de extensão.
//Esta classe deve ser estática.
public static class ExtensionMethods
{
    // Mesmo que sejam usados ​​como métodos normais,
    // os métodos de extensão devem ser declarados estáticos.
    // Observe que o primeiro parâmetro tem a palavra-chave 'this'
    // seguida por uma variável Transform.
    // Essa variável denota de qual classe o método de extensão se torna parte.
    public static void ResetTransformation(this Transform tform)
    {
        tform.position = Vector3.zero;
        //Os quatérnios permitem interpolar entre as
        //transformações de rotação aplicadas a um objeto,
        //tornando mais fácil calcular animações suaves de rotações.
        //Um quatérnio representa um eixo de rotação e uma rotação em torno desse eixo.
        tform.localRotation = Quaternion.identity;
        tform.localScale = new Vector3(1, 1, 1);
    }
    
}
