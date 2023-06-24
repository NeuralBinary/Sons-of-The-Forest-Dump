using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	[ExecuteInEditMode]
	public class TerrainDetailBakeManager : MonoBehaviour
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x330F260", Offset = "0x330D860", VA = "0x18330F260")]
		private Vector2 CalculateCellSize()
		{
			return default(Vector2);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TerrainDetailBakeManager()
		{
		}

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		private const string ErrorMissingBakeManager = "Could not bake detail maps for the active scene as";

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _worldDimensions;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2Int _gridSize;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _drawGridOverlay;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bakeRoot;

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private TerrainDetailMap[,] _detailGrid;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private Vector2Int _lastBakedGridSize;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x50")]
		private bool _initialized;

		// Token: 0x04001D76 RID: 7542
		[Token(Token = "0x4001D76")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextAsset[] _textSources;
	}
}
