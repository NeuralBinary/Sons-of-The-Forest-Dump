using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	internal abstract class ProceduralLogShape
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009B")]
		internal Transform Parent
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009C")]
		internal IVisualInstanceProvider VisualInstanceProvider
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00002E1C File Offset: 0x0000101C
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009D")]
		internal VisualModes Mode
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			[CompilerGenerated]
			get
			{
				return VisualModes.Normal;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9D2340", Offset = "0x9D0940", VA = "0x1809D2340")]
		internal void Init(Transform parent, IVisualInstanceProvider visualInstanceProvider, VisualModes mode)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2DB3E80", Offset = "0x2DB2480", VA = "0x182DB3E80")]
		internal void SpawnLog(Vector3 pos, Quaternion rotation, float scale, ref int addedVisuals)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2DB41D0", Offset = "0x2DB27D0", VA = "0x182DB41D0")]
		internal void SpawnLogPlank(Vector3 pos, Quaternion rotation, ref int addedVisuals)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2DB4410", Offset = "0x2DB2A10", VA = "0x182DB4410", Slot = "4")]
		public virtual void TrimExtraLogs(int addedVisuals)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2DB4610", Offset = "0x2DB2C10", VA = "0x182DB4610", Slot = "5")]
		public virtual void TrimExtraLogPlanks(int addedVisuals)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ProceduralLogShape()
		{
		}
	}
}
