using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public interface IBridgeRopeSupport : IFloorSupport, ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CDC RID: 3292
		[Token(Token = "0x6000CDC")]
		bool CanHostNewBridgeRope(Directions snapDir);

		// Token: 0x06000CDD RID: 3293
		[Token(Token = "0x6000CDD")]
		void SetBridgeRope(Directions dir, BridgeRopeStructure bridgeRope);

		// Token: 0x06000CDE RID: 3294
		[Token(Token = "0x6000CDE")]
		bool TryGetBridgeRope(Directions dir, out BridgeRopeStructure bridgeRope);

		// Token: 0x06000CDF RID: 3295
		[Token(Token = "0x6000CDF")]
		Vector3 GetBridgeRopeSnapPos();

		// Token: 0x06000CE0 RID: 3296
		[Token(Token = "0x6000CE0")]
		Vector3 GetBridgeRopeSecondSnapPos(IBridgeRopeSupport otherSupport);
	}
}
