using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(ParticleSystem))]
	public class LightningParticleCollisionForwarder : MonoBehaviour
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA4E0E0", Offset = "0xA4C6E0", VA = "0x180A4E0E0")]
		private void Start()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA4E170", Offset = "0xA4C770", VA = "0x180A4E170")]
		private void OnParticleCollision(GameObject other)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA4E2C0", Offset = "0xA4C8C0", VA = "0x180A4E2C0")]
		public LightningParticleCollisionForwarder()
		{
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The script to forward the collision to. Must implement ICollisionHandler.")]
		public MonoBehaviour CollisionHandler;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem _particleSystem;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<ParticleCollisionEvent> collisionEvents;
	}
}
