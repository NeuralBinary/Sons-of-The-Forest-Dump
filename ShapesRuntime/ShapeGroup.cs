using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[ExecuteAlways]
	public class ShapeGroup : MonoBehaviour
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000032B4 File Offset: 0x000014B4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AE")]
		internal bool IsEnabled
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2A2C510", Offset = "0x2A2AB10", VA = "0x182A2C510")]
		private void OnEnable()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2A2C5E0", Offset = "0x2A2ABE0", VA = "0x182A2C5E0")]
		private void OnDisable()
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AF")]
		public Color Color
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xAA8B70", Offset = "0xAA7170", VA = "0x180AA8B70")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2A2C630", Offset = "0x2A2AC30", VA = "0x182A2C630")]
			set
			{
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2A2C640", Offset = "0x2A2AC40", VA = "0x182A2C640")]
		private void OnValidate()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2A2C650", Offset = "0x2A2AC50", VA = "0x182A2C650")]
		private void UpdateChildShapes()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2655FD0", Offset = "0x26545D0", VA = "0x182655FD0")]
		public ShapeGroup()
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		public static int shapeGroupsInScene;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ShapesColorField(true)]
		private Color color;
	}
}
