// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "CM163/MyShader"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)

        // Variable name (label, data type) = default value
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM
            
            #pragma vertex vert
            #pragma fragment frag

            float4 _Color;

            struct VertexShaderInput
            {
            	float4 vertex: POSITION;
            };

            struct VertexShaderOutput
            {
            	float4 pos: SV_POSITION;
            };

            

            VertexShaderOutput vert(VertexShaderInput v)
            {
            	VertexShaderOutput o;

            	o.pos = UnityObjectToClipPos(v.vertex);

            	return o;
            }

            float4 frag(VertexShaderOutput i): SV_TARGET
            {
            	return _Color;//float4(1,0,0,1);
            }

            ENDCG
        }
    }
}

