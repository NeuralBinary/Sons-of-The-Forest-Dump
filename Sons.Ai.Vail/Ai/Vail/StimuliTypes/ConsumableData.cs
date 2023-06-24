using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.StatSystem;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[Serializable]
	public class ConsumableData
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000C0")]
		public List<StatAdjustment> StatAdjustments
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000C1")]
		public List<StatAdjustment> OwnerInfluenceAdjustments
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x2B98950", Offset = "0x2B96F50", VA = "0x182B98950")]
		public void SetStatAdjustments(List<StatAdjustment> value)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ConsumableData()
		{
		}

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<StatAdjustment> _statAdjustments;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StatAdjustment> _ownerInfluenceAdjustments;
	}
}
