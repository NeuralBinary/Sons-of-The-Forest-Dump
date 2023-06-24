using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[AddComponentMenu("Sons/Construction/CompoundStructure")]
	public class CompoundStructure : Structure, ITargetablePlacement
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000290")]
		public static Counter Counter
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x2E8F690", Offset = "0x2E8DC90", VA = "0x182E8F690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00006944 File Offset: 0x00004B44
		[Token(Token = "0x17000291")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x2370A50", Offset = "0x236F050", VA = "0x182370A50", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x2E8F7B0", Offset = "0x2E8DDB0", VA = "0x182E8F7B0", Slot = "105")]
		private StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x2E8F9C0", Offset = "0x2E8DFC0", VA = "0x182E8F9C0", Slot = "106")]
		private void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 pos, out Quaternion rot, out float lengthScale)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x2E8FA00", Offset = "0x2E8E000", VA = "0x182E8FA00", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2E8FAD0", Offset = "0x2E8E0D0", VA = "0x182E8FAD0")]
		public CompoundStructure()
		{
		}
	}
}
