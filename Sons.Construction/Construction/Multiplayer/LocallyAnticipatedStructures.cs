using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	[AddComponentMenu("Sons/Construction/LocallyAnticipatedStructures")]
	public class LocallyAnticipatedStructures : SingletonBehaviour<LocallyAnticipatedStructures>
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0000BE64 File Offset: 0x0000A064
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043B")]
		public int PlaceActionNum
		{
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x2960BE0", Offset = "0x295F1E0", VA = "0x182960BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x2DE94B0", Offset = "0x2DE7AB0", VA = "0x182DE94B0", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x2DE96D0", Offset = "0x2DE7CD0", VA = "0x182DE96D0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x2DE9780", Offset = "0x2DE7D80", VA = "0x182DE9780")]
		public void RegisterPostInitCallback(Action action)
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x2DE97F0", Offset = "0x2DE7DF0", VA = "0x182DE97F0")]
		private void BeginRegisterAnticipatedStructure(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x2DE98D0", Offset = "0x2DE7ED0", VA = "0x182DE98D0")]
		private void StopRegisterAnticipatedStructure(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x2DE99C0", Offset = "0x2DE7FC0", VA = "0x182DE99C0")]
		private void BeginRegisterAnticipatedStructure()
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x2DE9AA0", Offset = "0x2DE80A0", VA = "0x182DE9AA0")]
		private void StopRegisterAnticipatedStructure()
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x2DE9B80", Offset = "0x2DE8180", VA = "0x182DE9B80")]
		public static void RegisterStructureDismantled(Structure structure)
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x2DE9DE0", Offset = "0x2DE83E0", VA = "0x182DE9DE0")]
		private void RegisterStructureCreated(Structure structure)
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x2DEA030", Offset = "0x2DE8630", VA = "0x182DEA030")]
		public void RemoveRejectedAnticipatedStructure(int rejectedPlaceActionNum)
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0000BE7C File Offset: 0x0000A07C
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x2DEA0C0", Offset = "0x2DE86C0", VA = "0x182DEA0C0")]
		public bool TryFindAnticipatedStructureActionNum(Structure structure, out int structureActionNum)
		{
			return default(bool);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x2DEA350", Offset = "0x2DE8950", VA = "0x182DEA350")]
		public void SetStructureInstanceID(int eventActionNum, int eventTypeID, int eventInstanceID)
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x2DEA6F0", Offset = "0x2DE8CF0", VA = "0x182DEA6F0")]
		public Structure TryIdentifyAnticipatedStructure(int typeId, int instanceId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x2DEAB80", Offset = "0x2DE9180", VA = "0x182DEAB80")]
		public void ValidateDismantled(int typeId, int instanceId)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x2DEAFF0", Offset = "0x2DE95F0", VA = "0x182DEAFF0")]
		public LocallyAnticipatedStructures()
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x2DEB160", Offset = "0x2DE9760", VA = "0x182DEB160")]
		[CompilerGenerated]
		private void <RemoveRejectedAnticipatedStructure>g__CheckRejectedStructureCreation|18_0(ref LocallyAnticipatedStructures.<>c__DisplayClass18_0 A_1)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x2DEB4D0", Offset = "0x2DE9AD0", VA = "0x182DEB4D0")]
		[CompilerGenerated]
		private void <RemoveRejectedAnticipatedStructure>g__CheckRejectedStructureDismantle|18_1(ref LocallyAnticipatedStructures.<>c__DisplayClass18_0 A_1)
		{
		}

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, List<Structure>> _anticipatedStructures;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, List<Structure>> _anticipatedDismantledStructures;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x38")]
		private Action _postInitCallback;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x40")]
		private bool _initialized;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x41")]
		private bool _usedActionNum;
	}
}
