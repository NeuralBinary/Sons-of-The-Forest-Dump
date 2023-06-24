using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[AddComponentMenu("Sons/Construction/InteriorSpaceSnowAndWetnessOcclusion")]
	public class InteriorSpaceSnowAndWetnessOcclusion : SingletonBehaviour<InteriorSpaceSnowAndWetnessOcclusion>
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2DCC280", Offset = "0x2DCA880", VA = "0x182DCC280", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2DCC340", Offset = "0x2DCA940", VA = "0x182DCC340", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2DCC3F0", Offset = "0x2DCA9F0", VA = "0x182DCC3F0")]
		private void SetMaxVolumes(string quality)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2DCC450", Offset = "0x2DCAA50", VA = "0x182DCC450")]
		private void Update()
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2DCC550", Offset = "0x2DCAB50", VA = "0x182DCC550")]
		private void FilterBestRooms(List<SuperStructure.Room> rooms)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2DCCB50", Offset = "0x2DCB150", VA = "0x182DCCB50")]
		private void SetOccluderForRooms(List<SuperStructure.Room> rooms)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2DCCD10", Offset = "0x2DCB310", VA = "0x182DCCD10")]
		private void ShowRoomDebugGizmo(SuperStructure.Room room)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2DCCD40", Offset = "0x2DCB340", VA = "0x182DCCD40")]
		private GameObject GetOccluderInstance(SuperStructure.Room room)
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2DCCF70", Offset = "0x2DCB570", VA = "0x182DCCF70")]
		public static void StartFadeInSingle(Renderer target, float duration)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2DCD1D0", Offset = "0x2DCB7D0", VA = "0x182DCD1D0")]
		public InteriorSpaceSnowAndWetnessOcclusion()
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2DCD5A0", Offset = "0x2DCBBA0", VA = "0x182DCD5A0")]
		[CompilerGenerated]
		private void <FilterBestRooms>g__GetBestPointForRoom|25_0(SuperStructure.Room room, out float dot, out float bottomHeight, out Vector3 pos)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2DCD980", Offset = "0x2DCBF80", VA = "0x182DCD980")]
		[CompilerGenerated]
		private float <FilterBestRooms>g__Dot|25_3(Vector3 pos)
		{
			return 0f;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2DCDB50", Offset = "0x2DCC150", VA = "0x182DCDB50")]
		[CompilerGenerated]
		private void <FilterBestRooms>g__InsertRoomByScore|25_1(SuperStructure.Room room, float score)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x141D350", Offset = "0x141B950", VA = "0x18141D350")]
		[CompilerGenerated]
		internal static void <FilterBestRooms>g__ShowFilteringDebug|25_2(SuperStructure.Room room, Vector3 bestPos, float bestDot, float distance, float score)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2DCDC40", Offset = "0x2DCC240", VA = "0x182DCDC40")]
		[CompilerGenerated]
		private void <SetOccluderForRooms>g__TrimToMaxRooms|26_0(ref InteriorSpaceSnowAndWetnessOcclusion.<>c__DisplayClass26_0 A_1)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2DCDD20", Offset = "0x2DCC320", VA = "0x182DCDD20")]
		[CompilerGenerated]
		private void <SetOccluderForRooms>g__ExtractAlreadyShownRooms|26_1(ref InteriorSpaceSnowAndWetnessOcclusion.<>c__DisplayClass26_0 A_1)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2DCE320", Offset = "0x2DCC920", VA = "0x182DCE320")]
		[CompilerGenerated]
		private void <SetOccluderForRooms>g__SetupOccludersForNewlyOccludedRooms|26_2(ref InteriorSpaceSnowAndWetnessOcclusion.<>c__DisplayClass26_0 A_1)
		{
		}

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Snow & Wetness Volumes")]
		private GameObject _occluderPrefab;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _occluderHeight;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _occluderHeightOffset;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _occluderSizeOffset;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _maxOccluders;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x40")]
		[Header("Local Snow & Wetness")]
		[SerializeField]
		private float _defaultSnowMaxLocalLevel;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x44")]
		[Header("Debug")]
		[SerializeField]
		private bool _showRoomsDebug;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		[Header("Debug")]
		private bool _showFilteringDebug;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x48")]
		private readonly Queue<GameObject> _occluderInstancesPool;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x50")]
		private readonly Dictionary<SuperStructure.Room, GameObject> _occluderInstances;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<SuperStructure.Room> _ceilingsRooms;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<SuperStructure.Room> _sortedCeilingsRooms;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<float> _ceilingsRoomsScores;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 _fadeInVolumePos;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x7C")]
		private Quaternion _fadeInVolumeRot;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 _fadeInSize;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x98")]
		private float _fadeInStartTime;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x9C")]
		private float _fadeInDuration;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0xA0")]
		private int _maxVolumesOnScreen;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0xA8")]
		private MaterialPropertyBlock _mtp;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SnowLocalLevel;
	}
}
