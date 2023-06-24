using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[AddComponentMenu("Sons/Weapon/StaggerController")]
	public class StaggerController : MonoBehaviour
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2AF8A50", Offset = "0x2AF7050", VA = "0x182AF8A50")]
		public void OnHitNode(DamageNode damageNode, float damage)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2AF8D10", Offset = "0x2AF7310", VA = "0x182AF8D10")]
		private void ResetAnimHashes()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2AF8DD0", Offset = "0x2AF73D0", VA = "0x182AF8DD0")]
		private void ResetStaggerDamage()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2AF8F00", Offset = "0x2AF7500", VA = "0x182AF8F00")]
		private void DoStagger(StaggerController.StaggerLocation location)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2AF9360", Offset = "0x2AF7960", VA = "0x182AF9360")]
		private void DoStagger(int locationParamValue)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2AF94F0", Offset = "0x2AF7AF0", VA = "0x182AF94F0")]
		public StaggerController()
		{
		}

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _minTimeBetweenStaggers;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<StaggerController.StaggerLocation> _locations;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x38")]
		private float _lastStaggerTime;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		private static int HitStaggerLocationHash;

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		[Serializable]
		private class StaggerLocation
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x000025C8 File Offset: 0x000007C8
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2AF95B0", Offset = "0x2AF7BB0", VA = "0x182AF95B0")]
			public bool CheckNodeHit(DamageNode damageNode, float damage)
			{
				return default(bool);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x12B0350", Offset = "0x12AE950", VA = "0x1812B0350")]
			public void ResetDamage()
			{
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000EA RID: 234 RVA: 0x000025E0 File Offset: 0x000007E0
			[Token(Token = "0x1700000E")]
			public int LocationAnimParam
			{
				[Token(Token = "0x60000EA")]
				[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000EB RID: 235 RVA: 0x000025F8 File Offset: 0x000007F8
			[Token(Token = "0x1700000F")]
			public bool IsStaggered
			{
				[Token(Token = "0x60000EB")]
				[Address(RVA = "0x2AF9730", Offset = "0x2AF7D30", VA = "0x182AF9730")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000EC RID: 236 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x17000010")]
			public string Name
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StaggerLocation()
			{
			}

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _name;

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private DamageNode[] _damageNodes;

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _damageToStagger;

			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private int _staggerLocationAnimParam;

			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x28")]
			private float _damageTaken;
		}
	}
}
