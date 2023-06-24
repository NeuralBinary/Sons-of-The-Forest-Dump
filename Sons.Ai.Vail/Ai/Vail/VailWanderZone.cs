using System;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Areas;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[AddComponentMenu("Sons/Characters/Vail Wander Zone")]
	public class VailWanderZone : MonoBehaviour, IActorZone
	{
		// Token: 0x0600089E RID: 2206 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x2B6F110", Offset = "0x2B6D710", VA = "0x182B6F110", Slot = "7")]
		public AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
		public int MinDay()
		{
			return 0;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x17000082")]
		public float Weight
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "6")]
		public bool KeepAboveTerrain()
		{
			return default(bool);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "5")]
		public BoundsShape GetWanderBounds(State actorState)
		{
			return null;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x2B6F200", Offset = "0x2B6D800", VA = "0x182B6F200")]
		private GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x2B6F2F0", Offset = "0x2B6D8F0", VA = "0x182B6F2F0")]
		private Vector3 SnapPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2B6F350", Offset = "0x2B6D950", VA = "0x182B6F350", Slot = "4")]
		public void TeleportToZone(WorldSimActor actor)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x2B6F720", Offset = "0x2B6DD20", VA = "0x182B6F720")]
		private void CreateBoundsShape()
		{
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x2B6F930", Offset = "0x2B6DF30", VA = "0x182B6F930")]
		public VailWanderZone()
		{
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoundsShape _bounds;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _spawnOnTerrain;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailZoneBase _cave;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Zone becomes active on this day")]
		private int _minDay;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _spawnWeight;
	}
}
