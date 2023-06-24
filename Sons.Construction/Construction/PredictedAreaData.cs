using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[Serializable]
	public class PredictedAreaData
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001E7")]
		public Dictionary<ItemData, List<PredictedTarget>> SnapPointsForHeldItem
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001E8")]
		public List<PredictedTarget> SnapPoints
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x170001E9")]
		public bool HasSnapPoints
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2E25790", Offset = "0x2E23D90", VA = "0x182E25790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2E257F0", Offset = "0x2E23DF0", VA = "0x182E257F0")]
		public List<PredictedTarget> GetItemTargetList(ItemData item)
		{
			return null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2E258E0", Offset = "0x2E23EE0", VA = "0x182E258E0")]
		public void Dispose()
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2E25E80", Offset = "0x2E24480", VA = "0x182E25E80")]
		public PredictedAreaData()
		{
		}
	}
}
