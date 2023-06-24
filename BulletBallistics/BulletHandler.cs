using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[AddComponentMenu("Ballistics/Bullet Handler")]
	public class BulletHandler : MonoBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000002")]
		public static BulletHandler instance
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x9062E0", Offset = "0x9048E0", VA = "0x1809062E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x906670", Offset = "0x904C70", VA = "0x180906670")]
		public BallisticSettings GetSettings()
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x906770", Offset = "0x904D70", VA = "0x180906770")]
		private void Awake()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x906930", Offset = "0x904F30", VA = "0x180906930")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x906A00", Offset = "0x905000", VA = "0x180906A00")]
		public BulletHandler.TrajectoryData SimulateBulletTrajectory(BulletData bulletToSimulate)
		{
			return default(BulletHandler.TrajectoryData);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9071C0", Offset = "0x9057C0", VA = "0x1809071C0")]
		private void UpdateBullets()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9076F0", Offset = "0x905CF0", VA = "0x1809076F0")]
		private void updateVelocity(ref BulletData bullet, float distance)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x907BB0", Offset = "0x9061B0", VA = "0x180907BB0")]
		private void checkPath(ref BulletData bullet, bool trajectoryTest = false)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9088D0", Offset = "0x906ED0", VA = "0x1809088D0")]
		private bool searchExit(ref BulletData bullet, Vector3 nextPosition, bool trajectoryTest = false)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x908E30", Offset = "0x907430", VA = "0x180908E30")]
		private void changeBulletDirection(ref BulletData bullet, Vector3 velocity, Vector3 normal, float spread)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x909240", Offset = "0x907840", VA = "0x180909240")]
		private void surfaceImpact(ref BulletData bullet, BallisticObject ballisticObject, ref RaycastHit rayHit, BallisticMaterial ballisticMaterial, bool trajectoryTest = false)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x909B70", Offset = "0x908170", VA = "0x180909B70")]
		private void impact(ref BulletData bullet, BulletImpact impact)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x909E10", Offset = "0x908410", VA = "0x180909E10")]
		private void stopBullet(ref BulletData bullet)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x909F30", Offset = "0x908530", VA = "0x180909F30")]
		public void AddBullet(BulletData bullet)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x90A000", Offset = "0x908600", VA = "0x18090A000")]
		public BulletHandler()
		{
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public List<BulletData> Bullets;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static BulletHandler _instance;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _debugTraceLine;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private BallisticSettings ballisticSettings;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		private const int maxHits = 32;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		private RaycastHit[] hits;

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public struct TrajectoryData
		{
			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x0")]
			public bool surfaceImpactDetected;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x8")]
			public BulletData bulletData;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x58")]
			public SurfaceImpactInfo resultingSurfaceImpactInfo;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0xA8")]
			public List<Vector3> arcPoints;
		}
	}
}
