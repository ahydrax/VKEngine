using Knfa.VK;
using Knfa.VK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace VKTests
{
    public class InvokerCoreTests
    {
        [Fact]
        public void TestDefaultCallParameters()
        {
            var api = new VkApi();

            const int lyricsId = 2428970;
            const int ownerId = 1;
            const int audioId = 190442705;

            Assert.Equal(true, api.AddDefaultArgument(TestsHelper.ApiVersion));
            Assert.Equal(false, api.AddDefaultArgument("v", "3.0"));
            Assert.Equal(false, api.AddDefaultArgument("v", 42));
            Assert.Equal(true, api.AddDefaultArgument(TestsHelper.AccessToken));

            var lyrics = api.Execute<Lyrics>(Methods.Audio.GetLyrics.GetName(),
                Argument.Create("lyrics_id", lyricsId)).Result;

            var audio = api.Execute<IEnumerable<Audio>>(Methods.Audio.GetById.GetName(),
                Argument.Create("audios", String.Format("{0}_{1}", ownerId, audioId))).Result.First();

            Assert.Equal(ownerId, audio.OwnerId);
            Assert.Equal(audioId, audio.Id);
            Assert.Equal(lyricsId, lyrics.Id);
        }
    }
}
