using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class SuperStructureManager : SingletonBehaviour<SuperStructureManager>
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000177")]
		public List<SuperStructure> AllSuperStructures
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x17000178")]
		public static bool UseOcclusionRooms
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2DDEB80", Offset = "0x2DDD180", VA = "0x182DDEB80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2DDEC00", Offset = "0x2DDD200", VA = "0x182DDEC00", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2DDED10", Offset = "0x2DDD310", VA = "0x182DDED10", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		private void OnUseOcclusionRoomsChanged(bool onOff)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2DDEE20", Offset = "0x2DDD420", VA = "0x182DDEE20")]
		private void CleanUp()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2DDEEF0", Offset = "0x2DDD4F0", VA = "0x182DDEEF0")]
		private void Update()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2DDF4B0", Offset = "0x2DDDAB0", VA = "0x182DDF4B0")]
		public static void Register(SuperStructure superStructure)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2DDF5F0", Offset = "0x2DDDBF0", VA = "0x182DDF5F0")]
		public static void Unregister(SuperStructure superStructure)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2DDF670", Offset = "0x2DDDC70", VA = "0x182DDF670")]
		public static void InitAfterLoadSave(ISuperStructureNode nodeA)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2DDF9C0", Offset = "0x2DDDFC0", VA = "0x182DDF9C0")]
		public static void Merge(ISuperStructureNode nodeA, ISuperStructureNode nodeB)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2DDFC40", Offset = "0x2DDE240", VA = "0x182DDFC40")]
		public static void SetDirty(IProcessableSuperStructure superStructure, bool dirtyOcclusion)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2DDFD70", Offset = "0x2DDE370", VA = "0x182DDFD70")]
		public static bool TryFindCeilingsInView(Transform mainTr, List<SuperStructure.Room> ceilings)
		{
			return default(bool);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2DE0450", Offset = "0x2DDEA50", VA = "0x182DE0450")]
		public static void Register(ISuperStructureRefreshedReceiver receiver)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2DE0590", Offset = "0x2DDEB90", VA = "0x182DE0590")]
		public static void Unregister(ISuperStructureRefreshedReceiver receiver)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2DE0610", Offset = "0x2DDEC10", VA = "0x182DE0610")]
		public SuperStructureManager()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2DE0900", Offset = "0x2DDEF00", VA = "0x182DE0900")]
		[CompilerGenerated]
		internal static bool <TryFindCeilingsInView>g__CheckShouldShowSuperStructure|20_0(SuperStructure superStructure, ref SuperStructureManager.<>c__DisplayClass20_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useOcclusionRooms;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<SuperStructure> _allSuperStructures;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<IProcessableSuperStructure> _dirtiedSuperStructures;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<IProcessableSuperStructure> _dirtiedOcclusionSuperStructures;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<ISuperStructureRefreshedReceiver> _receivers;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x50")]
		private Plane[] _cameraFrustrumPlanes;
	}
}
