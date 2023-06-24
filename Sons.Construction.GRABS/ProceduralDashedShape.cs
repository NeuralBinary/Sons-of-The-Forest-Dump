using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	internal abstract class ProceduralDashedShape
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000092")]
		internal Transform Parent
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000093")]
		internal IVisualInstanceProvider VisualInstanceProvider
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002D74 File Offset: 0x00000F74
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000094")]
		internal VisualModes Mode
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return VisualModes.Normal;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x9D2340", Offset = "0x9D0940", VA = "0x1809D2340")]
		internal void Init(Transform parent, IVisualInstanceProvider visualInstanceProvider, VisualModes mode)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2DAF9D0", Offset = "0x2DADFD0", VA = "0x182DAF9D0")]
		internal void SpawnLine(Vector3 p1, Vector3 p2, float dashLength, Material dashMat, ref int addedVisuals)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2DAFF00", Offset = "0x2DAE500", VA = "0x182DAFF00", Slot = "4")]
		public virtual void TrimExtraVisuals(int addedVisuals)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ProceduralDashedShape()
		{
		}
	}
}
