using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public class InventoryFakeGroundSelector : MonoBehaviour, ISeasonsReceiver
	{
		// Token: 0x0600275C RID: 10076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x33C3E60", Offset = "0x33C2460", VA = "0x1833C3E60")]
		private void Awake()
		{
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x33C3E70", Offset = "0x33C2470", VA = "0x1833C3E70")]
		private void OnEnable()
		{
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x33C3E80", Offset = "0x33C2480", VA = "0x1833C3E80", Slot = "4")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x33C3EB0", Offset = "0x33C24B0", VA = "0x1833C3EB0")]
		private void Initialize()
		{
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x33C3FC0", Offset = "0x33C25C0", VA = "0x1833C3FC0")]
		private void SelectWorldAreaType()
		{
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x33C4070", Offset = "0x33C2670", VA = "0x1833C4070")]
		private void ApplyOutsideLayout()
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x33C4970", Offset = "0x33C2F70", VA = "0x1833C4970")]
		private void ApplyLayout(List<GameObject> layouts)
		{
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x33C4C90", Offset = "0x33C3290", VA = "0x1833C4C90")]
		private void SelectActiveOutsideLayout(int terrainLayerIndex)
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x33C4F30", Offset = "0x33C3530", VA = "0x1833C4F30")]
		private static bool CheckLayerListForIndex(IEnumerable<int> layers, IReadOnlyList<GameObject> layouts, int prominantLayerIndex, ref GameObject activeLayerObject)
		{
			return default(bool);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x33C5220", Offset = "0x33C3820", VA = "0x1833C5220")]
		public InventoryFakeGroundSelector()
		{
		}

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _groundRenderer;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _forestLayouts;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _forestFallLayouts;

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<int> _forestTerrainLayers;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GameObject> _beachLayouts;

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<int> _beachTerrainLayers;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<GameObject> _caveLayouts;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<int> _caveTerrainLayers;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<GameObject> _bunkerLayouts;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<int> _bunkerTerrainLayers;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GameObject> _raftLayouts;

		// Token: 0x040023A0 RID: 9120
		[Token(Token = "0x40023A0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<int> _raftTerrainLayers;

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x80")]
		private GameObject _activeLayout;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x88")]
		private SeasonsManager.Season _currentSeason;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x8C")]
		private bool _isInitialized;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x90")]
		private Material _material;

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x98")]
		private int _prominantTerrainLayerIndex;
	}
}
