using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public interface IConstructionVailActions
	{
		// Token: 0x0600055C RID: 1372
		[Token(Token = "0x600055C")]
		GameObject BuildFire(Vector3 position, Quaternion rotation);

		// Token: 0x0600055D RID: 1373
		[Token(Token = "0x600055D")]
		GameObject StartDefensiveWall(Vector3 position, Quaternion rotation);

		// Token: 0x0600055E RID: 1374
		[Token(Token = "0x600055E")]
		bool TryAddPillarToWall(GameObject targetWall, Vector3 position);

		// Token: 0x0600055F RID: 1375
		[Token(Token = "0x600055F")]
		GameObject BuildTarp(Vector3 position, Quaternion rotation);

		// Token: 0x06000560 RID: 1376
		[Token(Token = "0x6000560")]
		bool TryGetClosestTarpStakePosition(GameObject targetTarp, Vector3 nearPosition, out Vector3 stakePos);

		// Token: 0x06000561 RID: 1377
		[Token(Token = "0x6000561")]
		bool TryBuildTarpStake(GameObject targetTarp, Vector3 nearPosition);

		// Token: 0x06000562 RID: 1378
		[Token(Token = "0x6000562")]
		bool TryRemoveTarp(GameObject targetTarp, Vector3 nearPosition);
	}
}
