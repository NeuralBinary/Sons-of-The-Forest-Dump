using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	[AddComponentMenu("Sons/Construction/SingleStepStructure")]
	public class SingleStepStructure : Structure
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00009B54 File Offset: 0x00007D54
		[Token(Token = "0x170003B6")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001007")]
			[Address(RVA = "0x2F0A3F0", Offset = "0x2F089F0", VA = "0x182F0A3F0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00009B6C File Offset: 0x00007D6C
		[Token(Token = "0x170003B7")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6001008")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003B8")]
		public BeamStructure BackSupport
		{
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x2F0A400", Offset = "0x2F08A00", VA = "0x182F0A400")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003B9")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x600100A")]
			[Address(RVA = "0x2F0A440", Offset = "0x2F08A40", VA = "0x182F0A440", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003BA")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x600100B")]
			[Address(RVA = "0x2F0A490", Offset = "0x2F08A90", VA = "0x182F0A490", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003BB")]
		public static Counter Counter
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x2F0A4E0", Offset = "0x2F08AE0", VA = "0x182F0A4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00009B84 File Offset: 0x00007D84
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00009B9C File Offset: 0x00007D9C
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "71")]
		public override int CalcMaxElements(StructureElement floorPrefab)
		{
			return 0;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00009BB4 File Offset: 0x00007DB4
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00009BCC File Offset: 0x00007DCC
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x2F0A530", Offset = "0x2F08B30", VA = "0x182F0A530", Slot = "76")]
		public override Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x2F0A690", Offset = "0x2F08C90", VA = "0x182F0A690")]
		public SingleStepStructure()
		{
		}

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
