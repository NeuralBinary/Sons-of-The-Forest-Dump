using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	[ExecuteInEditMode]
	public class TerrainDetailBakeManager : MonoBehaviour
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x2D33240", Offset = "0x2D32240", VA = "0x182D33240")]
		private Vector2 CalculateCellSize()
		{
			return default(Vector2);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public TerrainDetailBakeManager()
		{
		}

		// Token: 0x04001D32 RID: 7474
		[Token(Token = "0x4001D32")]
		private const string ErrorMissingBakeManager = "Could not bake detail maps for the active scene as";

		// Token: 0x04001D33 RID: 7475
		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _worldDimensions;

		// Token: 0x04001D34 RID: 7476
		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2Int _gridSize;

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _drawGridOverlay;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bakeRoot;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private TerrainDetailMap[,] _detailGrid;

		// Token: 0x04001D38 RID: 7480
		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Vector2Int _lastBakedGridSize;

		// Token: 0x04001D39 RID: 7481
		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x50")]
		private bool _initialized;

		// Token: 0x04001D3A RID: 7482
		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextAsset[] _textSources;
	}
}
