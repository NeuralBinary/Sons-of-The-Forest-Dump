using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public interface IBeamSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CD3 RID: 3283
		[Token(Token = "0x6000CD3")]
		Vector3 GetBeamSnapPos(Vector3 targetPos);

		// Token: 0x06000CD4 RID: 3284
		[Token(Token = "0x6000CD4")]
		bool TryGetBeamSnapPoint(Vector3 fromPoint, Vector3 nearPoint, out Vector3 snapPos, out Directions targetDir, out IBeamSupport targetSupport, out int supportQuality);

		// Token: 0x06000CD5 RID: 3285
		[Token(Token = "0x6000CD5")]
		void LinkSupportedBeamsTogether(ref Directions supportDir, ref BeamDirections beamDir, BeamStructure beam);

		// Token: 0x06000CD6 RID: 3286
		[Token(Token = "0x6000CD6")]
		bool CanHostNewBeam();

		// Token: 0x06000CD7 RID: 3287
		[Token(Token = "0x6000CD7")]
		Directions[] GetAllBeamSnapPointsDirs();

		// Token: 0x06000CD8 RID: 3288
		[Token(Token = "0x6000CD8")]
		bool TryGetBeamPlaceInfo(Directions targetDir, out Vector3 snapPos, out Vector3 placeAxis, out Vector3 lookAxis, out float lookAxisMaxDot, out bool lookupForwardStitching, out bool allowLeaning);

		// Token: 0x06000CD9 RID: 3289
		[Token(Token = "0x6000CD9")]
		Vector3 GetBeamPlaceAxisFromBeamDir(Directions dir);

		// Token: 0x06000CDA RID: 3290
		[Token(Token = "0x6000CDA")]
		bool IsCompatibleWith(IBeamSupport otherSupport);

		// Token: 0x06000CDB RID: 3291
		[Token(Token = "0x6000CDB")]
		bool AllowsLiftingBeam();
	}
}
