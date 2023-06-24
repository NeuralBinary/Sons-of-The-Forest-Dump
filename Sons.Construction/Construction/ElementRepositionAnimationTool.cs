using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public class ElementRepositionAnimationTool
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x2F42D80", Offset = "0x2F41380", VA = "0x182F42D80")]
		public void Add(StructureElement element)
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0000B60C File Offset: 0x0000980C
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x2F432C0", Offset = "0x2F418C0", VA = "0x182F432C0")]
		public bool HasElements()
		{
			return default(bool);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x2F43310", Offset = "0x2F41910", VA = "0x182F43310")]
		public IEnumerator Play()
		{
			return null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x2F433A0", Offset = "0x2F419A0", VA = "0x182F433A0")]
		public ElementRepositionAnimationTool()
		{
		}

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x10")]
		private readonly float _duration;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<ElementRepositionAnimationTool.Data> _elements;

		// Token: 0x0200026C RID: 620
		[Token(Token = "0x200026C")]
		private class Data
		{
			// Token: 0x060012D4 RID: 4820 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Data()
			{
			}

			// Token: 0x04000953 RID: 2387
			[Token(Token = "0x4000953")]
			[FieldOffset(Offset = "0x10")]
			public StructureElement _targetElement;

			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 _originalPosition;

			// Token: 0x04000955 RID: 2389
			[Token(Token = "0x4000955")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 _rendererWorldOffset;

			// Token: 0x04000956 RID: 2390
			[Token(Token = "0x4000956")]
			[FieldOffset(Offset = "0x30")]
			public Quaternion _originalRotation;
		}
	}
}
