using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class AvatarUtility
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x28DA580", Offset = "0x28D8B80", VA = "0x1828DA580")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x28DA880", Offset = "0x28D8E80", VA = "0x1828DA880")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x28DB170", Offset = "0x28D9770", VA = "0x1828DB170")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return HumanBodyBones.Hips;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AvatarUtility()
		{
		}
	}
}
