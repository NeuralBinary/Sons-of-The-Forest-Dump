using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	internal class ShapesMaterials
	{
		// Token: 0x170001C5 RID: 453
		[Token(Token = "0x170001C5")]
		public Material this[ShapesBlendMode type]
		{
			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0xA16100", Offset = "0xA14700", VA = "0x180A16100")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x2A4A9F0", Offset = "0x2A48FF0", VA = "0x182A4A9F0")]
		public ShapesMaterials(string shaderName, params string[] keywords)
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x2A4AF20", Offset = "0x2A49520", VA = "0x182A4AF20")]
		public static string GetMaterialName(string shaderName, string blendModeSuffix, params string[] keywords)
		{
			return null;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x2A4B060", Offset = "0x2A49660", VA = "0x182A4B060")]
		public static void ApplyDefaultGlobalProperties(Material mat)
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x2A4B1D0", Offset = "0x2A497D0", VA = "0x182A4B1D0")]
		private static Material CreateShapesMaterial(Shader shader, HideFlags hideFlags, params string[] keywords)
		{
			return null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x2A4B490", Offset = "0x2A49A90", VA = "0x182A4B490")]
		private static Material InitMaterial(string shaderName, string blendModeSuffix, params string[] keywords)
		{
			return null;
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		private const bool USE_INSTANCING = true;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		public const string SHAPES_SHADER_PATH_PREFIX = "Shapes/";

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		private readonly Material[] materials;
	}
}
