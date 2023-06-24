using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	[AddComponentMenu("Sons/Construction/ConstructionWarmthProbe")]
	public class ConstructionWarmthProbe : MonoBehaviour
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2DCB420", Offset = "0x2DC9A20", VA = "0x182DCB420")]
		private void Start()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2DCB500", Offset = "0x2DC9B00", VA = "0x182DCB500")]
		public void Update()
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2DCB5F0", Offset = "0x2DC9BF0", VA = "0x182DCB5F0")]
		private void UpdateInteriorSpace(bool isInside)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2DCB7C0", Offset = "0x2DC9DC0", VA = "0x182DCB7C0")]
		private void UpdateWarmth(bool isWarm)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2DCB990", Offset = "0x2DC9F90", VA = "0x182DCB990")]
		private bool LookupRoomAndWarmth(out bool hasCeiling, out bool isWarm)
		{
			return default(bool);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2DCBE30", Offset = "0x2DCA430", VA = "0x182DCBE30")]
		public void Register(IWarmthProbeReceiver receiver)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2DCBF30", Offset = "0x2DCA530", VA = "0x182DCBF30")]
		public void Unregister(IWarmthProbeReceiver receiver)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2DCBF90", Offset = "0x2DCA590", VA = "0x182DCBF90")]
		public void Register(IInteriorSpaceProbeReceiver receiver)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2DCC090", Offset = "0x2DCA690", VA = "0x182DCC090")]
		public void Unregister(IInteriorSpaceProbeReceiver receiver)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2DCC0F0", Offset = "0x2DCA6F0", VA = "0x182DCC0F0")]
		public ConstructionWarmthProbe()
		{
		}

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _receivers;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _refreshDelay;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _maxGroundDistance;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInRoom;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x31")]
		private bool _isWarm;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x34")]
		private float _nextRefreshTime;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<IWarmthProbeReceiver> _warmthReceivers;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<IInteriorSpaceProbeReceiver> _interiorSpaceReceivers;
	}
}
