using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	public interface IFloorSupport : ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CED RID: 3309
		[Token(Token = "0x6000CED")]
		bool AreSiblingStructuresSupportingFloorsAtDir(Directions targetDir);

		// Token: 0x06000CEE RID: 3310
		[Token(Token = "0x6000CEE")]
		bool HasLinkedPerpendicularFloorSupports(Directions targetDir);

		// Token: 0x06000CEF RID: 3311
		[Token(Token = "0x6000CEF")]
		void GetNearbyFloors(List<FloorStructure> list, int siblingDistance);

		// Token: 0x06000CF0 RID: 3312
		[Token(Token = "0x6000CF0")]
		void SetFloorAtDir(Directions direction, FloorStructure floor);

		// Token: 0x06000CF1 RID: 3313
		[Token(Token = "0x6000CF1")]
		bool TryGetFloorAtDir(Directions direction, out FloorStructure floor);

		// Token: 0x06000CF2 RID: 3314
		[Token(Token = "0x6000CF2")]
		bool HasFloorAtDir(Directions direction);

		// Token: 0x06000CF3 RID: 3315
		[Token(Token = "0x6000CF3")]
		bool CanHostNewFloor();
	}
}
