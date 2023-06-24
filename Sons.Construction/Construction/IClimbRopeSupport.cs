using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public interface IClimbRopeSupport : IFloorSupport, ITileSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CE1 RID: 3297
		[Token(Token = "0x6000CE1")]
		bool CanHostNewClimbRope(Directions snapDir);

		// Token: 0x06000CE2 RID: 3298
		[Token(Token = "0x6000CE2")]
		void SetClimbRope(Directions dir, PresetStructure bridgeRope);

		// Token: 0x06000CE3 RID: 3299
		[Token(Token = "0x6000CE3")]
		bool TryGetClimbRope(Directions dir, out PresetStructure bridgeRope);

		// Token: 0x06000CE4 RID: 3300
		[Token(Token = "0x6000CE4")]
		Vector3 GetClimbRopeSnapPos(Directions dir);
	}
}
