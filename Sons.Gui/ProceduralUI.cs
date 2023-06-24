using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class ProceduralUI : MonoBehaviour
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x300BF00", Offset = "0x300A500", VA = "0x18300BF00")]
		public void AddLine2pElement(RectTransform rt, Vector3 fromPos, Vector3 toPos)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x300C040", Offset = "0x300A640", VA = "0x18300C040")]
		public void AddSimpleAnchorElement(RectTransform rt, Vector3 worldPos)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x300C170", Offset = "0x300A770", VA = "0x18300C170")]
		private void Awake()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x300C440", Offset = "0x300AA40", VA = "0x18300C440")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x300C5D0", Offset = "0x300ABD0", VA = "0x18300C5D0")]
		public ProceduralUI()
		{
		}

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProceduralUI.Line2P _testLine;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ProceduralUI.Rect2P _testRect2p;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProceduralUI.SimpleAnchor _testSimpleAnchor;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x38")]
		private List<ProceduralUI.Element> _activeElements;

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public abstract class Element
		{
			// Token: 0x060000F9 RID: 249
			[Token(Token = "0x60000F9")]
			public abstract void Draw();

			// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			protected Element()
			{
			}
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[Serializable]
		public class Line2P : ProceduralUI.Element
		{
			// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x300C6B0", Offset = "0x300ACB0", VA = "0x18300C6B0")]
			public void Init(RectTransform rt, Vector3 from, Vector3 to)
			{
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x300C730", Offset = "0x300AD30", VA = "0x18300C730", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Line2P()
			{
			}

			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform RT;

			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 From;

			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 To;
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[Serializable]
		public class Rect2P : ProceduralUI.Element
		{
			// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x300C9D0", Offset = "0x300AFD0", VA = "0x18300C9D0")]
			public void Init(RectTransform rt, Vector3 from, Vector3 to, float worldWidth)
			{
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x300CA60", Offset = "0x300B060", VA = "0x18300CA60", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Rect2P()
			{
			}

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform RT;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 From;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 To;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x30")]
			public float WorldWidth;
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		[Serializable]
		public class SimpleAnchor : ProceduralUI.Element
		{
			// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x300D190", Offset = "0x300B790", VA = "0x18300D190")]
			public void Init(RectTransform rt, Vector3 worldPos)
			{
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x300D1F0", Offset = "0x300B7F0", VA = "0x18300D1F0", Slot = "4")]
			public override void Draw()
			{
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SimpleAnchor()
			{
			}

			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform RT;

			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 WorldPos;
		}
	}
}
