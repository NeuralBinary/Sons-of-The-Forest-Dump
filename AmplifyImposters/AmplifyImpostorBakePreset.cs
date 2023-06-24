using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[CreateAssetMenu(fileName = "New Bake Preset", order = 86)]
	public class AmplifyImpostorBakePreset : ScriptableObject
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5B85F0", Offset = "0x5B6BF0", VA = "0x1805B85F0")]
		public AmplifyImpostorBakePreset()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Shader BakeShader;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Shader RuntimeShader;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public PresetPipeline Pipeline;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public int AlphaIndex;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public List<TextureOutput> Output;
	}
}
