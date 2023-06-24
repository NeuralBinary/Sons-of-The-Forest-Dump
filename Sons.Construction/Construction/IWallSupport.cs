using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	public interface IWallSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000D3F RID: 3391
		[Token(Token = "0x6000D3F")]
		bool CanHostNewWall();

		// Token: 0x06000D40 RID: 3392
		[Token(Token = "0x6000D40")]
		void SetWallAtDir(Directions dir, WallStructure wall);

		// Token: 0x06000D41 RID: 3393
		[Token(Token = "0x6000D41")]
		bool HasWallAtDir(Directions dir);

		// Token: 0x06000D42 RID: 3394
		[Token(Token = "0x6000D42")]
		bool TryGetWallAtDir(Directions dir, out WallStructure wall);

		// Token: 0x06000D43 RID: 3395
		[Token(Token = "0x6000D43")]
		Directions[] GetAllWallSnapPointsDirs();

		// Token: 0x06000D44 RID: 3396
		[Token(Token = "0x6000D44")]
		Directions GetWallDirForWallPos(Vector3 wallPos);

		// Token: 0x06000D45 RID: 3397
		[Token(Token = "0x6000D45")]
		bool TryGetWallPlacementInfo(Directions dir, StructureElement profileElementPrefab, out Vector3 snapPos, out Vector3 placeAxis);
	}
}
