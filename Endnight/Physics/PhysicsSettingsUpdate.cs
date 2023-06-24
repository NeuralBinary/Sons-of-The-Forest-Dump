using System;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public class PhysicsSettingsUpdate : SingletonBehaviour<PhysicsSettingsUpdate>
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA9B7B0", Offset = "0xA99DB0", VA = "0x180A9B7B0")]
		public PhysicsSettingsUpdate()
		{
		}

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fpsUpdateRate;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _physicsUpdateRate;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PhysicsSettingsUpdateDefinition _definition;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x38")]
		private int _frameCount;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x3C")]
		private float _deltaTimeSum;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x40")]
		private float _currentSetting;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x44")]
		private float _fps;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x48")]
		private float _timeSinceLastPhysicsUpdate;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x4C")]
		private int _previousPhysicsSettingIndex;
	}
}
