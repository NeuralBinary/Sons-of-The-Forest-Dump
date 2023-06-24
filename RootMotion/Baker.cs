using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace RootMotion
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28D8920", Offset = "0x28D6F20", VA = "0x1828D8920")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x28D89B0", Offset = "0x28D6FB0", VA = "0x1828D89B0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x28D8A40", Offset = "0x28D7040", VA = "0x1828D8A40")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x28D8AD0", Offset = "0x28D70D0", VA = "0x1828D8AD0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x28D8B60", Offset = "0x28D7160", VA = "0x1828D8B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x28D8B70", Offset = "0x28D7170", VA = "0x1828D8B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		protected abstract Transform GetCharacterRoot();

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		protected abstract void OnStartBaking();

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		protected abstract void OnSetLoopFrame(float time);

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		private protected float clipLength
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			[CompilerGenerated]
			protected get
			{
				return 0f;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x28D8B80", Offset = "0x28D7180", VA = "0x1828D8B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void BakeClip()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void StartBaking()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void StopBaking()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x28D8B90", Offset = "0x28D7190", VA = "0x1828D8B90")]
		protected Baker()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 90f)]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		public int frameRate;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Baker.Mode mode;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[Serializable]
		public enum Mode
		{
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			AnimationClips,
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			AnimationStates,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			PlayableDirector,
			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			Realtime
		}
	}
}
