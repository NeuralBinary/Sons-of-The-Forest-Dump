using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Areas;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x0200076B RID: 1899
	[Token(Token = "0x200076B")]
	[AddComponentMenu("Sons/Player/CustomActions/DeathMarkerGroup")]
	public class DeathMarkerGroup : MonoBehaviour
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[Token(Token = "0x17000646")]
		public bool IsGroupEnabled
		{
			[Token(Token = "0x60031DE")]
			[Address(RVA = "0x5A15F0", Offset = "0x5A05F0", VA = "0x1805A15F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000647")]
		public IReadOnlyList<PlayerDeathCutsceneMarker> AllMarkers
		{
			[Token(Token = "0x60031DF")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x17000648")]
		public AreaMask Area
		{
			[Token(Token = "0x60031E0")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(AreaMask);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x17000649")]
		public DeathMarkerGroupMask GroupMask
		{
			[Token(Token = "0x60031E1")]
			[Address(RVA = "0x6C5570", Offset = "0x6C4570", VA = "0x1806C5570")]
			get
			{
				return DeathMarkerGroupMask.None;
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x2E44370", Offset = "0x2E43370", VA = "0x182E44370")]
		private void OnValidate()
		{
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x2E43F80", Offset = "0x2E42F80", VA = "0x182E43F80")]
		private void FindMarkers()
		{
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x2E43CE0", Offset = "0x2E42CE0", VA = "0x182E43CE0")]
		private void FindChildMarkers()
		{
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x2E443F0", Offset = "0x2E433F0", VA = "0x182E443F0")]
		private void ReorderMarkers()
		{
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x2E44630", Offset = "0x2E43630", VA = "0x182E44630")]
		private void UpdateIds()
		{
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x2E43AF0", Offset = "0x2E42AF0", VA = "0x182E43AF0")]
		private string ConvertToString(DeathMarkerGroupMask groupMask)
		{
			return null;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x2E43BB0", Offset = "0x2E42BB0", VA = "0x182E43BB0")]
		private string ConvertToString(AreaMask area)
		{
			return null;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x5A1820", Offset = "0x5A0820", VA = "0x1805A1820")]
		public void SetGroupEnabled(bool value)
		{
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x60031EA")]
		[Address(RVA = "0x2E444A0", Offset = "0x2E434A0", VA = "0x182E444A0")]
		public bool TryGetMarkerFromHash(int markerHash, out PlayerDeathCutsceneMarker marker)
		{
			return default(bool);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EB")]
		[Address(RVA = "0x2E43A00", Offset = "0x2E42A00", VA = "0x182E43A00")]
		private void Awake()
		{
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x2E442B0", Offset = "0x2E432B0", VA = "0x182E442B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x2E44200", Offset = "0x2E43200", VA = "0x182E44200")]
		public bool MatchesDeathMarker(AreaMask area, DeathMarkerGroupMask groupMask)
		{
			return default(bool);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x2E44280", Offset = "0x2E43280", VA = "0x182E44280")]
		private bool MatchesDeathMarker(DeathMarkerGroupMask groupMask)
		{
			return default(bool);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x2E44250", Offset = "0x2E43250", VA = "0x182E44250")]
		private bool MatchesDeathMarker(AreaMask area)
		{
			return default(bool);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x2E44BE0", Offset = "0x2E43BE0", VA = "0x182E44BE0")]
		public DeathMarkerGroup()
		{
		}

		// Token: 0x04002B7F RID: 11135
		[Token(Token = "0x4002B7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AreaMask _area;

		// Token: 0x04002B80 RID: 11136
		[Token(Token = "0x4002B80")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_groupId")]
		[SerializeField]
		private DeathMarkerGroupMask _groupMask;

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<PlayerDeathCutsceneMarker> _markers;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _groupEnabled;
	}
}
