using UnityEditor;

public class CreateHLSLFile
{
    static string newHLSLTemplate = @"#ifndef #FILENAME#_INCLUDED
#define #FILENAME#_INCLUDED

void ExampleFunction_float(float In, out float Out)
{
	// This example function just inverse pixel value
	Out = 1 - In;
}

#endif";

    [MenuItem("Assets/Create/Shader/HLSL Shader")]
    static void CreateCustomFunction() => ProjectWindowUtil.CreateAssetWithContent("New HLSL Shader.hlsl", newHLSLTemplate);
}
