using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	[AddComponentMenu("Sons/Player/CustomActions/DeathMarkerGroup")]
	public class DeathMarkerGroup : MonoBehaviour
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x170005B3")]
		public bool IsGroupEnabled
		{
			[Token(Token = "0x6002B55")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B4")]
		public IReadOnlyList<PlayerDeathCutsceneMarker> AllMarkers
		{
			[Token(Token = "0x6002B56")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x170005B5")]
		public AreaMask Area
		{
			[Token(Token = "0x6002B57")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return AreaMask.None;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x170005B6")]
		public DeathMarkerGroupMask GroupMask
		{
			[Token(Token = "0x6002B58")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return DeathMarkerGroupMask.None;
			}
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x340CA70", Offset = "0x340B070", VA = "0x18340CA70")]
		private void OnValidate()
		{
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x340CAF0", Offset = "0x340B0F0", VA = "0x18340CAF0")]
		private void FindMarkers()
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x340CF80", Offset = "0x340B580", VA = "0x18340CF80")]
		private void FindChildMarkers()
		{
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x340D4D0", Offset = "0x340BAD0", VA = "0x18340D4D0")]
		private void ReorderMarkers()
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x340D630", Offset = "0x340BC30", VA = "0x18340D630")]
		private void UpdateIds()
		{
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x340DC10", Offset = "0x340C210", VA = "0x18340DC10")]
		private string ConvertToString(DeathMarkerGroupMask groupMask)
		{
			return null;
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x340DCD0", Offset = "0x340C2D0", VA = "0x18340DCD0")]
		private string ConvertToString(AreaMask area)
		{
			return null;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
		public void SetGroupEnabled(bool value)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x340DE00", Offset = "0x340C400", VA = "0x18340DE00")]
		public bool TryGetMarkerFromHash(int markerHash, out PlayerDeathCutsceneMarker marker)
		{
			return default(bool);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x340E060", Offset = "0x340C660", VA = "0x18340E060")]
		private void Awake()
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x340E1B0", Offset = "0x340C7B0", VA = "0x18340E1B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x340E270", Offset = "0x340C870", VA = "0x18340E270")]
		public bool MatchesDeathMarker(AreaMask area, DeathMarkerGroupMask groupMask)
		{
			return default(bool);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x340E2C0", Offset = "0x340C8C0", VA = "0x18340E2C0")]
		private bool MatchesDeathMarker(DeathMarkerGroupMask groupMask)
		{
			return default(bool);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x340E2F0", Offset = "0x340C8F0", VA = "0x18340E2F0")]
		private bool MatchesDeathMarker(AreaMask area)
		{
			return default(bool);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x340E320", Offset = "0x340C920", VA = "0x18340E320")]
		public DeathMarkerGroup()
		{
		}

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AreaMask _area;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("_groupId")]
		private DeathMarkerGroupMask _groupMask;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerDeathCutsceneMarker> _markers;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _groupEnabled;
	}
}
