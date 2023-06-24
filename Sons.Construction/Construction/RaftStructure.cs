using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	[AddComponentMenu("Sons/Construction/RaftStructure")]
	public class RaftStructure : Structure
	{
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003A9")]
		public static Counter Counter
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x2F04500", Offset = "0x2F02B00", VA = "0x182F04500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x000098B4 File Offset: 0x00007AB4
		[Token(Token = "0x170003AA")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x22DA7E0", Offset = "0x22D8DE0", VA = "0x1822DA7E0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x2F04550", Offset = "0x2F02B50", VA = "0x182F04550", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000098CC File Offset: 0x00007ACC
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x2F04560", Offset = "0x2F02B60", VA = "0x182F04560", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x2F04550", Offset = "0x2F02B50", VA = "0x182F04550", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000098E4 File Offset: 0x00007AE4
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x2F046D0", Offset = "0x2F02CD0", VA = "0x182F046D0")]
		private void UpdateBuoyancy()
		{
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x2F04AE0", Offset = "0x2F030E0", VA = "0x182F04AE0")]
		public RaftStructure()
		{
		}

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _massPerRaftLog;
	}
}
