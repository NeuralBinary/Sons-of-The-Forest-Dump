using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x299A310", Offset = "0x2998910", VA = "0x18299A310")]
		private void Start()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x299A4D0", Offset = "0x2998AD0", VA = "0x18299A4D0")]
		private void RotateShoulders()
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x299A620", Offset = "0x2998C20", VA = "0x18299A620")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x299ADB0", Offset = "0x29993B0", VA = "0x18299ADB0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x299AED0", Offset = "0x29994D0", VA = "0x18299AED0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x299B0B0", Offset = "0x29996B0", VA = "0x18299B0B0")]
		public ShoulderRotator()
		{
		}

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x28")]
		private FullBodyBipedIK ik;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x30")]
		private bool skip;
	}
}
