using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	public class InventoryFakeGroundSelector : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x2D9AD10", Offset = "0x2D99D10", VA = "0x182D9AD10")]
		private void Awake()
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x2D9AFE0", Offset = "0x2D99FE0", VA = "0x182D9AFE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x2D9AFF0", Offset = "0x2D99FF0", VA = "0x182D9AFF0", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x2D9AF60", Offset = "0x2D99F60", VA = "0x182D9AF60")]
		private void Initialize()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x2D9B190", Offset = "0x2D9A190", VA = "0x182D9B190")]
		private void SelectWorldAreaType()
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x2D9A7C0", Offset = "0x2D997C0", VA = "0x182D9A7C0")]
		private void ApplyOutsideLayout()
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x2D9A690", Offset = "0x2D99690", VA = "0x182D9A690")]
		private void ApplyLayout(List<GameObject> layouts)
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x2D9B020", Offset = "0x2D9A020", VA = "0x182D9B020")]
		private void SelectActiveOutsideLayout(int terrainLayerIndex)
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x2D9AD20", Offset = "0x2D99D20", VA = "0x182D9AD20")]
		private static bool CheckLayerListForIndex(IEnumerable<int> layers, IReadOnlyList<GameObject> layouts, int prominantLayerIndex, ref GameObject activeLayerObject)
		{
			return default(bool);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x2D9B260", Offset = "0x2D9A260", VA = "0x182D9B260")]
		public InventoryFakeGroundSelector()
		{
		}

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _groundRenderer;

		// Token: 0x040022B8 RID: 8888
		[Token(Token = "0x40022B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _forestLayouts;

		// Token: 0x040022B9 RID: 8889
		[Token(Token = "0x40022B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _forestFallLayouts;

		// Token: 0x040022BA RID: 8890
		[Token(Token = "0x40022BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<int> _forestTerrainLayers;

		// Token: 0x040022BB RID: 8891
		[Token(Token = "0x40022BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _beachLayouts;

		// Token: 0x040022BC RID: 8892
		[Token(Token = "0x40022BC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<int> _beachTerrainLayers;

		// Token: 0x040022BD RID: 8893
		[Token(Token = "0x40022BD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GameObject> _caveLayouts;

		// Token: 0x040022BE RID: 8894
		[Token(Token = "0x40022BE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<int> _caveTerrainLayers;

		// Token: 0x040022BF RID: 8895
		[Token(Token = "0x40022BF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _bunkerLayouts;

		// Token: 0x040022C0 RID: 8896
		[Token(Token = "0x40022C0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<int> _bunkerTerrainLayers;

		// Token: 0x040022C1 RID: 8897
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GameObject> _raftLayouts;

		// Token: 0x040022C2 RID: 8898
		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<int> _raftTerrainLayers;

		// Token: 0x040022C3 RID: 8899
		[Token(Token = "0x40022C3")]
		[FieldOffset(Offset = "0x80")]
		private GameObject _activeLayout;

		// Token: 0x040022C4 RID: 8900
		[Token(Token = "0x40022C4")]
		[FieldOffset(Offset = "0x88")]
		private SeasonsManager.Season _currentSeason;

		// Token: 0x040022C5 RID: 8901
		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x8C")]
		private bool _isInitialized;

		// Token: 0x040022C6 RID: 8902
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x90")]
		private Material _material;

		// Token: 0x040022C7 RID: 8903
		[Token(Token = "0x40022C7")]
		[FieldOffset(Offset = "0x98")]
		private int _prominantTerrainLayerIndex;
	}
}
