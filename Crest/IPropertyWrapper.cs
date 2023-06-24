using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public interface IPropertyWrapper
	{
		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		void SetFloat(int param, float value);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		void SetFloatArray(int param, float[] value);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		void SetVector(int param, Vector4 value);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		void SetVectorArray(int param, Vector4[] value);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		void SetTexture(int param, Texture value);

		// Token: 0x06000087 RID: 135
		[Token(Token = "0x6000087")]
		void SetMatrix(int param, Matrix4x4 matrix);

		// Token: 0x06000088 RID: 136
		[Token(Token = "0x6000088")]
		void SetInt(int param, int value);
	}
}
