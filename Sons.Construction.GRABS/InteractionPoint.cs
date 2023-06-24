using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class InteractionPoint
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000071")]
		public InteractionPointMB Behaviour
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		public VisualFader Visual
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		public BlueprintFace Face
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000074")]
		public InteractionPointDefinition Definition
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void Register(IInteractionPointEventReceiver eventReceiver)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2D99C70", Offset = "0x2D98270", VA = "0x182D99C70")]
		public void Unregister(IInteractionPointEventReceiver eventReceiver)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2D99CD0", Offset = "0x2D982D0", VA = "0x182D99CD0")]
		internal void Grabbed(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2D99E40", Offset = "0x2D98440", VA = "0x182D99E40")]
		internal void UnGrabbed(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2D9A110", Offset = "0x2D98710", VA = "0x182D9A110")]
		internal void StartedOperation(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2D9A1D0", Offset = "0x2D987D0", VA = "0x182D9A1D0")]
		internal void FinishedOperation(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2D9A230", Offset = "0x2D98830", VA = "0x182D9A230")]
		internal bool TryGrab(Ray aimRay, float maxGrabDistance, float closestGrabDot, out float dotToGrabPoint)
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2D9A840", Offset = "0x2D98E40", VA = "0x182D9A840")]
		public void MoveToPositionRelativeToFace()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2D9ABC0", Offset = "0x2D991C0", VA = "0x182D9ABC0")]
		private bool TryCalcInterTilePosition(Ray aimRay, int lengthAxisNum, out Vector3 ipPos)
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2D9AE00", Offset = "0x2D99400", VA = "0x182D9AE00")]
		private bool TryGetBetweenTilePos(Vector3 aimPos, Vector3 from, Vector3 to, int lengthAxisNum, out Vector3 ipPos)
		{
			return default(bool);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2D9B400", Offset = "0x2D99A00", VA = "0x182D9B400")]
		private bool TryCalcOnEdgePosition(Ray aimRay, out Vector3 ipPos, out Vector3 ipForwardAxis)
		{
			return default(bool);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InteractionPoint()
		{
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		private IInteractionPointEventReceiver _eventReceiver;
	}
}
