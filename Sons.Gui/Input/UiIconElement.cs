using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Input
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[AddComponentMenu("Sons/Gui/Input/UiIconElement")]
	public class UiIconElement : MonoBehaviour
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x305D8D0", Offset = "0x305BED0", VA = "0x18305D8D0")]
		private void Awake()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x305DA00", Offset = "0x305C000", VA = "0x18305DA00")]
		public void SetMaterial(Material source)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x305DC30", Offset = "0x305C230", VA = "0x18305DC30")]
		public void RestoreMaterial()
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void SetOutlineMaterial(Material source)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x305DD10", Offset = "0x305C310", VA = "0x18305DD10")]
		public void SetTexture(Texture sourceTexture)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x305DD90", Offset = "0x305C390", VA = "0x18305DD90")]
		public void SetOutlineTexture(Texture sourceTexture)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x305DEF0", Offset = "0x305C4F0", VA = "0x18305DEF0")]
		public void SetText(string text)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x305DF70", Offset = "0x305C570", VA = "0x18305DF70")]
		private void ApplyShader(Material source)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x305E6F0", Offset = "0x305CCF0", VA = "0x18305E6F0")]
		private static void GetTextureData(Material source, out Texture texture, out Vector2 offset, out Vector2 scale)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UiIconElement()
		{
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _graphic;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _graphicOutline;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Shader _forceShader;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x38")]
		private Material _originalMaterial;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MainTex;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BaseColorMap;
	}
}
