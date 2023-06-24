using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[AddComponentMenu("Path-o-logical/TargetPro/Messenger")]
	public class TargetProMessenger : MonoBehaviour
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x28CFF30", Offset = "0x28CE530", VA = "0x1828CFF30")]
		private void Awake()
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x28CFF60", Offset = "0x28CE560", VA = "0x1828CFF60")]
		private void handleMsg(string msg)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		private void handleMsg<T>(string msg, T arg)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x28D0120", Offset = "0x28CE720", VA = "0x1828D0120")]
		private void RegisterFireController()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x28D08E0", Offset = "0x28CEEE0", VA = "0x1828D08E0")]
		private void OnStartDelegate()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x28D0930", Offset = "0x28CEF30", VA = "0x1828D0930")]
		private void OnUpdateDelegate()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x28D0980", Offset = "0x28CEF80", VA = "0x1828D0980")]
		private void OnTargetUpdateDelegate(List<Target> targets)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x28D09F0", Offset = "0x28CEFF0", VA = "0x1828D09F0")]
		private void OnIdleUpdateDelegate()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x28D0A40", Offset = "0x28CF040", VA = "0x1828D0A40")]
		private void OnFireDelegate(List<Target> targets)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x28D0AB0", Offset = "0x28CF0B0", VA = "0x1828D0AB0")]
		private void OnStopDelegate()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x28D0B00", Offset = "0x28CF100", VA = "0x1828D0B00")]
		private void RegisterProjectile()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x28D0CD0", Offset = "0x28CF2D0", VA = "0x1828D0CD0")]
		private void OnLauchedDelegate()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x28D0D20", Offset = "0x28CF320", VA = "0x1828D0D20")]
		private void LaunchedUpdateDelegate()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x28D0D70", Offset = "0x28CF370", VA = "0x1828D0D70")]
		private void OnDetonationDelegate(List<Target> targets)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x28D0DE0", Offset = "0x28CF3E0", VA = "0x1828D0DE0")]
		private void RegisterTargetable()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x28D1070", Offset = "0x28CF670", VA = "0x1828D1070")]
		private void OnHitDelegate(HitEffectList effects, Target target)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x28D1200", Offset = "0x28CF800", VA = "0x1828D1200")]
		private void OnDetectedDelegate(TargetTracker source)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x28D1270", Offset = "0x28CF870", VA = "0x1828D1270")]
		private void OnNotDetectedDelegate(TargetTracker source)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TargetProMessenger()
		{
		}

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x20")]
		public TargetProMessenger.COMPONENTS forComponent;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x24")]
		public TargetProMessenger.MESSAGE_MODE messageMode;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject otherTarget;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x30")]
		public DEBUG_LEVELS debugLevel;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x34")]
		public bool fireController_OnStart;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x35")]
		public bool fireController_OnUpdate;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x36")]
		public bool fireController_OnTargetUpdate;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x37")]
		public bool fireController_OnIdleUpdate;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x38")]
		public bool fireController_OnFire;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x39")]
		public bool fireController_OnStop;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x3A")]
		public bool projectile_OnLaunched;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x3B")]
		public bool projectile_OnLaunchedUpdate;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x3C")]
		public bool projectile_OnDetonation;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x3D")]
		public bool targetable_OnHit;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x3E")]
		public bool targetable_OnDetected;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x3F")]
		public bool targetable_OnNotDetected;

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		public enum COMPONENTS
		{
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			FireController,
			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			Projectile,
			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			Targetable
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		public enum MESSAGE_MODE
		{
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			Send,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			Broadcast
		}
	}
}
