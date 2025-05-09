using System.Diagnostics.CodeAnalysis;

#pragma warning disable CS1591
namespace Betalgo.Ranul.OpenAI.ObjectModels;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public static class Models
{
    public enum BaseModel
    {
        Ada,
        Babbage,
        Curie,
        Davinci,
        Cushman,
        None
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Model
    {
        Ada,
        Babbage,
        Curie,
        Davinci,

        TextAdaV1,
        TextBabbageV1,
        TextCurieV1,
        TextDavinciV1,

        TextDavinciV2,
        TextDavinciV3,

        CurieInstructBeta,
        DavinciInstructBeta,

        CurieSimilarityFast,

        TextSimilarityAdaV1,
        TextSimilarityBabbageV1,
        TextSimilarityCurieV1,
        TextSimilarityDavinciV1,

        TextSearchAdaDocV1,
        TextSearchBabbageDocV1,
        TextSearchCurieDocV1,
        TextSearchDavinciDocV1,

        TextSearchAdaQueryV1,
        TextSearchBabbageQueryV1,
        TextSearchCurieQueryV1,
        TextSearchDavinciQueryV1,

        TextEditDavinciV1,
        CodeEditDavinciV1,

        TextEmbeddingAdaV2,
        TextEmbeddingV3Small,
        TextEmbeddingV3Large,

        CodeSearchAdaCodeV1,
        CodeSearchBabbageCodeV1,

        CodeSearchAdaTextV1,
        CodeSearchBabbageTextV1,

        CodeDavinciV1,
        CodeCushmanV1,

        CodeDavinciV2,

        [Obsolete("Use Gpt_3_5_Turbo instead")] ChatGpt3_5Turbo,
        Gpt_3_5_Turbo,

        [Obsolete("Use Gpt_3_5_Turbo_0301 instead")] ChatGpt3_5Turbo0301,
        Gpt_3_5_Turbo_0301,

        Gpt_3_5_Turbo_16k,
        Gpt_3_5_Turbo_16k_0613,
        Gpt_3_5_Turbo_0613,
        Gpt_3_5_Turbo_1106,
        Gpt_3_5_Turbo_0125,
        Gpt_3_5_Turbo_Instruct,

        Gpt_4,
        Gpt_4_0314,
        Gpt_4_0613,
        Gpt_4_32k,
        Gpt_4_32k_0314,
        Gpt_4_32k_0613,
        Gpt_4_1106_preview,
        Gpt_4_0125_preview,
        Gpt_4_vision_preview,
        Gpt_4_turbo_preview,
        Gpt_4_turbo,
        Gpt_4_turbo_2024_04_09,

        Gpt_4_1,
        Gpt_4_1_2025_04_14,
        Gpt_4_1_mini,
        Gpt_4_1_mini_2025_04_14,
        Gpt_4_1_nano,
        Gpt_4_1_nano_2025_04_14,

        Gpt_4o,
        Gpt_4o_2024_05_13,
        Gpt_4o_2024_08_06,
        Gpt_4o_mini,
        Gpt_4o_mini_2024_07_18,
        Chatgpt_4o_latest,

        WhisperV1,

        Dall_e_2,
        Dall_e_3,

        Tts_1,
        Tts_1_hd,

        Text_moderation_007,
        Text_moderation_latest,
        Text_moderation_stable,
        O1,
        O1_2024_12_17,
        O1_preview,
        O1_preview_2024_09_12,
        O1_mini,
        O1_mini_2024_09_12,
        O1_pro_2025_03_19,

        O3_2025_04_16,
        O3_mini,
        O3_mini_2025_01_31,
        
        O4_mini_2025_04_16,
        Gpt_4o_realtime_preview_2024_10_01
    }

    public enum Subject
    {
        Text,
        InstructBeta,
        SimilarityFast,
        TextSimilarity,
        TextSearchDocument,
        TextSearchQuery,
        CodeSearchCode,
        CodeSearchText,
        Code,
        CodeEdit,
        Edit,
        TextEmbedding,
        TextModeration
    }

    /// <summary>
    ///     More capable than any GPT-3.5 model, able to do more complex tasks, and optimized for chat. Will be updated with
    ///     our latest model iteration.
    ///     8,192 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4 => "gpt-4";

    /// <summary>
    ///     Same capabilities as the base gpt-4 mode but with 4x the context length. Will be updated with our latest model
    ///     iteration.
    ///     32,768 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4_32k => "gpt-4-32k";

    /// <summary>
    ///     Snapshot of gpt-4 from March 14th 2023. Unlike gpt-4, this model will not receive updates, and will only be
    ///     supported for a three month period ending on June 14th 2023.
    ///     8,192 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4_0314 => "gpt-4-0314";

    /// <summary>
    ///     Snapshot of gpt-4-32 from March 14th 2023. Unlike gpt-4-32k, this model will not receive updates, and will only be
    ///     supported for a three month period ending on June 14th 2023.
    ///     32,768 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4_32k_0314 => "gpt-4-32k-0314";

    /// <summary>
    ///     Snapshot of gpt-4 from June 13th 2023 with function calling data. Unlike gpt-4, this model will not receive
    ///     updates,
    ///     and will be deprecated 3 months after a new version is released.
    ///     8,192 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4_0613 => "gpt-4-0613";

    /// <summary>
    ///     Snapshot of gpt-4-32 from June 13th 2023. Unlike gpt-4-32k, this model will not receive updates,
    ///     and will be deprecated 3 months after a new version is released.
    ///     32,768 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_4_32k_0613 => "gpt-4-32k-0613";

    /// <summary>
    ///     The latest GPT-4 model with improved instruction following, JSON mode, reproducible outputs, parallel function
    ///     calling, and more.
    ///     Returns a maximum of 4,096 output tokens. This preview model is not yet suited for production traffic.
    ///     128,000 tokens	Up to Apr 2023
    /// </summary>
    public static string Gpt_4_1106_preview => "gpt-4-1106-preview";

    public static string Gpt_4_0125_preview => "gpt-4-0125-preview";

    /// <summary>
    ///     Ability to understand images, in addition to all other GPT-4 Turbo capabilties.
    ///     Returns a maximum of 4,096 output tokens. This is a preview model version and not suited yet for production
    ///     traffic.
    ///     128,000 tokens	Up to Apr 2023
    /// </summary>
    public static string Gpt_4_vision_preview => "gpt-4-vision-preview";

    public static string Gpt_4_turbo_preview => "gpt-4-turbo-preview";

    /// <summary>
    ///     The latest GPT-4 Turbo model with vision capabilities. Vision requests can now use JSON mode and function calling.
    ///     Currently points to gpt-4-turbo-2024-04-09 as of 04/09/2024.
    ///     128,000 tokens	Up to Dec 2023
    /// </summary>
    public static string Gpt_4_turbo => "gpt-4-turbo";

    /// <summary>
    ///     GPT-4 Turbo with Vision model. Vision requests can now use JSON mode and function calling.
    ///     `gpt-4-turbo` currently points to this version.
    ///     128,000 tokens	Up to Dec 2023
    /// </summary>
    public static string Gpt_4_turbo_2024_04_09 => "gpt-4-turbo-2024-04-09";

    /// <summary>
    /// GPT-4.1: The flagship model with superior performance in coding, instruction following, and long-context understanding.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1 => "gpt-4.1";

    /// <summary>
    /// Original snapshot of GPT-4.1 from April 14th 2025. Has the same capabilities as the base GPT-4.1 model.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1_2025_04_14 => "gpt-4.1-2025-04-14";

    /// <summary>
    /// GPT-4.1 Mini: A cost-effective medium-sized model with excellent performance rivaling the full GPT-4.1 model. Optimized for better speed while maintaining high quality results.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1_mini => "gpt-4.1-mini";

    /// <summary>
    /// Original snapshot of GPT-4.1-mini from April 14th 2025. Has the same capabilities as the base GPT-4.1-mini model.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1_mini_2025_04_14 => "gpt-4.1-mini-2025-04-14";

    /// <summary>
    /// GPT-4.1 Nano: The smallest and most cost-effective model in the GPT-4.1 family. Approximately 75% cheaper than GPT-4.1-mini while still excellent for simpler tasks.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1_nano => "gpt-4.1-nano";

    /// <summary>
    /// Snapshot of GPT-4.1-nano from April 14th 2025. Has the same capabilities as the base GPT-4.1-nano model.
    /// Context Window: 1,047,576 tokens
    /// Max output tokens: 32,768 tokens
    /// Training data: Up to May 31, 2024
    /// </summary>
    public static string Gpt_4_1_nano_2025_04_14 => "gpt-4.1-nano-2025-04-14";

    /// <summary>
    /// GPT-4o: Our high-intelligence flagship model for complex, multi-step tasks. GPT-4o is cheaper and faster than GPT-4 Turbo. Currently points to gpt-4o-2024-08-06.
    /// Context Window: 128,000 tokens
    /// Max output tokens: 16,384 tokens
    /// Training data: Up to Oct 2023
    /// </summary>
    public static string Gpt_4o => "gpt-4o";

    /// <summary>
    ///    Original gpt-4o snapshot from May 13, 2024.
    /// Context Window: 128,000 tokens
    /// Max output tokens: 4,096 tokens
    /// Training data: Up to Oct 2023
    /// </summary>
    public static string Gpt_4o_2024_05_13 => "gpt-4o-2024-05-13";
    /// <summary>
    /// Latest snapshot that supports Structured Outputs. gpt-4o currently points to this version.
    /// Context Window: 128,000 tokens
    /// Max output tokens: 16,384 tokens
    /// Training data: Up to Oct 2023
    /// </summary>
    public static string Gpt_4o_2024_08_06 => "gpt-4o-2024-08-06";

    /// <summary>
    ///     Our affordable and intelligent small model for fast, lightweight tasks.
    ///     GPT-4o mini is cheaper and more capable than GPT-3.5 Turbo.
    ///     Currently points to gpt-4o-mini-2024-07-18.
    ///     128,000 tokens Up to Oct 2023
    /// </summary>
    public static string Gpt_4o_mini => "gpt-4o-mini";

    /// <summary>
    ///     Our affordable and intelligent small model for fast, lightweight tasks.
    ///     GPT-4o mini is cheaper and more capable than GPT-3.5 Turbo.
    ///     Currently points to gpt-4o-mini-2024-07-18.
    ///     128,000 tokens Up to Oct 2023
    /// </summary>
    public static string Gpt_4o_mini_2024_07_18 => "gpt-4o-mini-2024-07-18";

    /// <summary>
    ///     Dynamic model continuously updated to the current version of GPT-4o in ChatGPT. <a href="https://platform.openai.com/docs/models#4ofootnote">Intended for research and evaluation [1]</a>.
    /// </summary>
    public static string Chatgpt_4o_latest => "chatgpt-4o-latest";
    

    public static string Gpt_4o_realtime_preview_2024_10_01 => "gpt-4o-realtime-preview-2024-10-01";


    public static string Ada => "ada";
    public static string Babbage => "babbage";
    public static string Curie => "curie";
    public static string Davinci => "davinci";

    public static string CurieInstructBeta => ModelNameBuilder(BaseModel.Curie, Subject.InstructBeta);
    public static string DavinciInstructBeta => ModelNameBuilder(BaseModel.Davinci, Subject.InstructBeta);

    public static string TextDavinciV1 => ModelNameBuilder(BaseModel.Davinci, Subject.Text, "001");
    public static string TextDavinciV2 => ModelNameBuilder(BaseModel.Davinci, Subject.Text, "002");
    public static string TextDavinciV3 => ModelNameBuilder(BaseModel.Davinci, Subject.Text, "003");
    public static string TextAdaV1 => ModelNameBuilder(BaseModel.Ada, Subject.Text, "001");
    public static string TextBabbageV1 => ModelNameBuilder(BaseModel.Babbage, Subject.Text, "001");
    public static string TextCurieV1 => ModelNameBuilder(BaseModel.Curie, Subject.Text, "001");

    public static string CurieSimilarityFast => ModelNameBuilder(BaseModel.Curie, Subject.SimilarityFast);

    public static string CodeDavinciV1 => ModelNameBuilder(BaseModel.Davinci, Subject.Code, "001");
    public static string CodeCushmanV1 => ModelNameBuilder(BaseModel.Cushman, Subject.Code, "001");
    public static string CodeDavinciV2 => ModelNameBuilder(BaseModel.Davinci, Subject.Code, "002");

    public static string TextSimilarityAdaV1 => ModelNameBuilder(BaseModel.Ada, Subject.TextSimilarity, "001");
    public static string TextSimilarityBabbageV1 => ModelNameBuilder(BaseModel.Babbage, Subject.TextSimilarity, "001");
    public static string TextSimilarityCurieV1 => ModelNameBuilder(BaseModel.Curie, Subject.TextSimilarity, "001");
    public static string TextSimilarityDavinciV1 => ModelNameBuilder(BaseModel.Davinci, Subject.TextSimilarity, "001");

    public static string TextSearchAdaDocV1 => ModelNameBuilder(BaseModel.Ada, Subject.TextSearchDocument, "001");
    public static string TextSearchBabbageDocV1 => ModelNameBuilder(BaseModel.Babbage, Subject.TextSearchDocument, "001");
    public static string TextSearchCurieDocV1 => ModelNameBuilder(BaseModel.Curie, Subject.TextSearchDocument, "001");
    public static string TextSearchDavinciDocV1 => ModelNameBuilder(BaseModel.Davinci, Subject.TextSearchDocument, "001");
    public static string TextSearchAdaQueryV1 => ModelNameBuilder(BaseModel.Ada, Subject.TextSearchQuery, "001");
    public static string TextSearchBabbageQueryV1 => ModelNameBuilder(BaseModel.Babbage, Subject.TextSearchQuery, "001");
    public static string TextSearchCurieQueryV1 => ModelNameBuilder(BaseModel.Curie, Subject.TextSearchQuery, "001");
    public static string TextSearchDavinciQueryV1 => ModelNameBuilder(BaseModel.Davinci, Subject.TextSearchQuery, "001");

    public static string TextEditDavinciV1 => ModelNameBuilder(BaseModel.Davinci, Subject.Edit, "001");
    public static string CodeEditDavinciV1 => ModelNameBuilder(BaseModel.Davinci, Subject.CodeEdit, "001");

    public static string CodeSearchAdaCodeV1 => ModelNameBuilder(BaseModel.Ada, Subject.CodeSearchCode, "001");
    public static string CodeSearchBabbageCodeV1 => ModelNameBuilder(BaseModel.Babbage, Subject.CodeSearchCode, "001");
    public static string CodeSearchAdaTextV1 => ModelNameBuilder(BaseModel.Ada, Subject.CodeSearchText, "001");
    public static string CodeSearchBabbageTextV1 => ModelNameBuilder(BaseModel.Babbage, Subject.CodeSearchText, "001");

    public static string TextEmbeddingAdaV2 => ModelNameBuilder(BaseModel.Ada, Subject.TextEmbedding, "002");
    public static string TextEmbeddingV3Small => ModelNameBuilder(BaseModel.None, Subject.TextEmbedding, "3-small");
    public static string TextEmbeddingV3Large => ModelNameBuilder(BaseModel.None, Subject.TextEmbedding, "3-large");

    public static string TextModeration007 => ModelNameBuilder(BaseModel.None, Subject.TextModeration, "007");
    public static string TextModerationLatest => ModelNameBuilder(BaseModel.None, Subject.TextModeration, "latest");
    public static string TextModerationStable => ModelNameBuilder(BaseModel.None, Subject.TextModeration, "stable");

    /// <summary>
    ///     Most capable GPT-3.5 model and optimized for chat at 1/10th the cost of text-davinci-003. Will be updated with our
    ///     latest model iteration.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    [Obsolete("Use Gpt_3_5_Turbo instead, this is just a naming change,the field will be removed in next versions")]
    public static string ChatGpt3_5Turbo => "gpt-3.5-turbo";

    /// <summary>
    ///     Most capable GPT-3.5 model and optimized for chat at 1/10th the cost of text-davinci-003. Will be updated with our
    ///     latest model iteration.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo => "gpt-3.5-turbo";

    /// <summary>
    ///     Same capabilities as the standard gpt-3.5-turbo model but with 4 times the context.
    ///     16,384 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_16k => "gpt-3.5-turbo-16k";

    /// <summary>
    ///     Snapshot of gpt-3.5-turbo from March 1st 2023. Unlike gpt-3.5-turbo, this model will not receive updates, and will
    ///     only be supported for a three month period ending on June 1st 2023.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    [Obsolete("Use Gpt_3_5_Turbo_0301 instead, this is just a naming change,the field will be removed in next versions")]
    public static string ChatGpt3_5Turbo0301 => "gpt-3.5-turbo-0301";

    /// <summary>
    ///     Snapshot of gpt-3.5-turbo from March 1st 2023. Unlike gpt-3.5-turbo, this model will not receive updates, and will
    ///     only be supported for a three month period ending on June 1st 2023.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_0301 => "gpt-3.5-turbo-0301";

    /// <summary>
    ///     Snapshot of gpt-3.5-turbo from June 13th 2023 with function calling data. Unlike gpt-3.5-turbo,
    ///     this model will not receive updates, and will be deprecated 3 months after a new version is released.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_0613 => "gpt-3.5-turbo-0613";

    /// <summary>
    ///     The latest GPT-3.5 Turbo model with improved instruction following, JSON mode, reproducible outputs, parallel
    ///     function calling, and more.
    ///     16,384 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_1106 => "gpt-3.5-turbo-1106";

    public static string Gpt_3_5_Turbo_0125 => "gpt-3.5-turbo-0125";

    /// <summary>
    ///     Snapshot of gpt-3.5-turbo from June 13th 2023 with function calling data. Unlike gpt-3.5-turbo,
    ///     this model will not receive updates, and will be deprecated 3 months after a new version is released.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_16k_0613 => "gpt-3.5-turbo-16k-0613";

    /// <summary>
    ///     Similar capabilities as text-davinci-003 but compatible with legacy Completions endpoint and not Chat Completions.
    ///     4,096 tokens	Up to Sep 2021
    /// </summary>
    public static string Gpt_3_5_Turbo_Instruct => "gpt-3.5-turbo-instruct";


    public static string WhisperV1 => "whisper-1";

    /// <summary>
    ///     The previous DALL·E model released in Nov 2022. The 2nd iteration of DALL·E with more realistic, accurate, and 4x
    ///     greater resolution images than the original model.
    /// </summary>
    public static string Dall_e_2 => "dall-e-2";

    /// <summary>
    ///     The latest DALL·E model released in Nov 2023.
    /// </summary>
    public static string Dall_e_3 => "dall-e-3";

    /// <summary>
    ///     TTS is an AI model that converts text to natural sounding spoken text.
    ///     tts-1 is optimized for real time text to speech use cases.
    ///     Released in Nov 2023.
    /// </summary>
    public static string Tts_1 => "tts-1";

    /// <summary>
    ///     TTS is an AI model that converts text to natural sounding spoken text.
    ///     tts-1-hd is optimized for quality
    ///     Released in Nov 2023.
    /// </summary>
    public static string Tts_1_hd => "tts-1-hd";

    /// <summary>
    ///     Reasoning model designed to solve hard problems across domains.
    ///     Released in Sep 2024.
    /// </summary>
    public static string O1_preview => "o1-preview";

    /// <summary>
    ///     Faster and cheaper reasoning model particularly good at coding, math, and science.
    ///     Released in Sep 2024.
    /// </summary>
    public static string O1_mini => "o1-mini";

    public static string O1_preview_2024_09_12 => "o1-preview-2024-09-12";

    public static string O1_mini_2024_09_12 => "o1-mini-2024-09-12";

    /// <summary>
    ///    Reasoning model designed to solve hard problems across domains.
    ///    Released in Dec 2024.
    /// </summary>
    public static string O1 => "o1";

    /// <summary>
    ///    Reasoning model designed to solve hard problems across domains.
    ///    Released in Dec 2024.
    /// </summary>
    public static string O1_2024_12_17 => "o1-2024-12-17";

    /// <summary>
    ///    Faster and cheaper reasoning model particularly good at coding, math, and science.
    ///    Released in Jan 2025.
    /// </summary>
    public static string O3_mini => "o3-mini";

    /// <summary>
    ///    Faster and cheaper reasoning model particularly good at coding, math, and science.
    ///    Released in Jan 2025.
    /// </summary>
    public static string O3_mini_2025_01_31 => "o3-mini-2025-01-31";

    /// <summary>
    ///     O1-pro is available in the Responses API only to enable support for multi-turn model interactions before responding to API requests, 
    ///     and other advanced API features in the future.
    ///     200,000 context window
    ///     100,000 max output tokens
    ///     Oct 01, 2023 knowledge cutoff
    ///     Reasoning token support
    /// </summary>
    public static string O1_pro_2025_03_19 => "o1-pro-2025-03-19";

    /// <summary>
    ///     O3 is a well-rounded and powerful model across domains. It sets a new standard for math, science, coding, 
    ///     and visual reasoning tasks. It also excels at technical writing and instruction-following.
    ///     200,000 context window
    ///     100,000 max output tokens
    ///     Jun 01, 2024 knowledge cutoff
    ///     Reasoning token support
    /// </summary>
    public static string O3_2025_04_16 => "o3-2025-04-16";

    /// <summary>
    ///     O4-mini is the latest small o-series model. It's optimized for fast, effective reasoning 
    ///     with exceptionally efficient performance in coding and visual tasks.
    ///     200,000 context window
    ///     100,000 max output tokens
    ///     Jun 01, 2024 knowledge cutoff
    ///     Reasoning token support
    /// </summary>
    public static string O4_mini_2025_04_16 => "o4-mini-2025-04-16";

    /// <summary>
    ///     This method does not guarantee returned model exists.
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="version"></param>
    /// <param name="baseModel"></param>
    /// <returns></returns>
    public static string ModelNameBuilder(this BaseModel baseModel, Subject? subject = null, string? version = null)
    {
        return ModelNameBuilder(baseModel == BaseModel.None ? null : baseModel.EnumToString(), subject?.EnumToString(baseModel.EnumToString()), version);
    }

    public static string ModelNameBuilder(string? baseModel, string? subject, string? version)
    {
        var response = subject ?? $"{baseModel}";

        if (!string.IsNullOrEmpty(version))
        {
            response += $"-{version}";
        }

        return response;
    }

    public static string EnumToString(this Model model)
    {
        return model switch
        {
            Model.Ada => Ada,
            Model.Babbage => Babbage,
            Model.Curie => Curie,
            Model.CurieInstructBeta => CurieInstructBeta,
            Model.Davinci => Davinci,
            Model.DavinciInstructBeta => DavinciInstructBeta,
            Model.TextDavinciV1 => TextDavinciV1,
            Model.TextDavinciV2 => TextDavinciV2,
            Model.TextDavinciV3 => TextDavinciV3,
            Model.TextAdaV1 => TextAdaV1,
            Model.TextBabbageV1 => TextBabbageV1,
            Model.TextCurieV1 => TextCurieV1,
            Model.CurieSimilarityFast => CurieSimilarityFast,
            Model.CodeDavinciV1 => CodeDavinciV1,
            Model.CodeCushmanV1 => CodeCushmanV1,
            Model.CodeDavinciV2 => CodeDavinciV2,
            Model.TextSimilarityAdaV1 => TextSimilarityAdaV1,
            Model.TextSimilarityBabbageV1 => TextSimilarityBabbageV1,
            Model.TextSimilarityCurieV1 => TextSimilarityCurieV1,
            Model.TextSimilarityDavinciV1 => TextSimilarityDavinciV1,
            Model.TextSearchAdaDocV1 => TextSearchAdaDocV1,
            Model.TextSearchBabbageDocV1 => TextSearchBabbageDocV1,
            Model.TextSearchCurieDocV1 => TextSearchCurieDocV1,
            Model.TextSearchDavinciDocV1 => TextSearchDavinciDocV1,
            Model.TextSearchAdaQueryV1 => TextSearchAdaQueryV1,
            Model.TextSearchBabbageQueryV1 => TextSearchBabbageQueryV1,
            Model.TextSearchCurieQueryV1 => TextSearchCurieQueryV1,
            Model.TextSearchDavinciQueryV1 => TextSearchDavinciQueryV1,
            Model.CodeSearchAdaCodeV1 => CodeSearchAdaCodeV1,
            Model.CodeSearchBabbageCodeV1 => CodeSearchBabbageCodeV1,
            Model.CodeSearchAdaTextV1 => CodeSearchAdaTextV1,
            Model.CodeSearchBabbageTextV1 => CodeSearchBabbageTextV1,
            Model.TextEditDavinciV1 => TextEditDavinciV1,
            Model.CodeEditDavinciV1 => CodeEditDavinciV1,
            Model.ChatGpt3_5Turbo => ChatGpt3_5Turbo,
            Model.Gpt_3_5_Turbo => Gpt_3_5_Turbo,
            Model.ChatGpt3_5Turbo0301 => ChatGpt3_5Turbo0301,
            Model.Gpt_3_5_Turbo_0301 => Gpt_3_5_Turbo_0301,
            Model.Gpt_3_5_Turbo_0613 => Gpt_3_5_Turbo_0613,
            Model.Gpt_3_5_Turbo_1106 => Gpt_3_5_Turbo_1106,
            Model.Gpt_3_5_Turbo_0125 => Gpt_3_5_Turbo_0125,
            Model.Gpt_3_5_Turbo_16k_0613 => Gpt_3_5_Turbo_16k_0613,
            Model.Gpt_3_5_Turbo_16k => Gpt_3_5_Turbo_16k,
            Model.Gpt_3_5_Turbo_Instruct => Gpt_3_5_Turbo_Instruct,
            Model.WhisperV1 => WhisperV1,
            Model.TextEmbeddingAdaV2 => TextEmbeddingAdaV2,
            Model.TextEmbeddingV3Small => TextEmbeddingV3Small,
            Model.TextEmbeddingV3Large => TextEmbeddingV3Large,
            Model.Gpt_4 => Gpt_4,
            Model.Gpt_4_0314 => Gpt_4_0314,
            Model.Gpt_4_32k => Gpt_4_32k,
            Model.Gpt_4_32k_0314 => Gpt_4_32k_0314,
            Model.Gpt_4_0613 => Gpt_4_0613,
            Model.Gpt_4_32k_0613 => Gpt_4_32k_0613,
            Model.Dall_e_2 => Dall_e_2,
            Model.Dall_e_3 => Dall_e_3,
            Model.Gpt_4_1106_preview => Gpt_4_1106_preview,
            Model.Gpt_4_0125_preview => Gpt_4_0125_preview,
            Model.Gpt_4_vision_preview => Gpt_4_vision_preview,
            Model.Gpt_4_turbo_preview => Gpt_4_turbo_preview,
            Model.Gpt_4_turbo => Gpt_4_turbo,
            Model.Gpt_4_turbo_2024_04_09 => Gpt_4_turbo_2024_04_09,
            Model.Gpt_4_1 => Gpt_4_1,
            Model.Gpt_4_1_2025_04_14 => Gpt_4_1_2025_04_14,
            Model.Gpt_4_1_mini => Gpt_4_1_mini,
            Model.Gpt_4_1_mini_2025_04_14 => Gpt_4_1_mini_2025_04_14,
            Model.Gpt_4_1_nano => Gpt_4_1_nano,
            Model.Gpt_4_1_nano_2025_04_14 => Gpt_4_1_nano_2025_04_14,
            Model.Gpt_4o => Gpt_4o,
            Model.Gpt_4o_2024_05_13 => Gpt_4o_2024_05_13,
            Model.Gpt_4o_2024_08_06 => Gpt_4o_2024_08_06,
            Model.Gpt_4o_mini => Gpt_4o_mini,
            Model.Gpt_4o_mini_2024_07_18 => Gpt_4o_mini_2024_07_18,
            Model.Chatgpt_4o_latest => Chatgpt_4o_latest,
            Model.Tts_1 => Tts_1,
            Model.Tts_1_hd => Tts_1_hd,
            Model.Text_moderation_007 => TextModeration007,
            Model.Text_moderation_latest => TextModerationLatest,
            Model.Text_moderation_stable => TextModerationStable,
            Model.O1_mini => O1_mini,
            Model.O1_mini_2024_09_12 => O1_mini_2024_09_12,
            Model.O1_preview => O1_preview,
            Model.O1_preview_2024_09_12 => O1_preview_2024_09_12,
            Model.O1 => O1,
            Model.O1_2024_12_17 => O1_2024_12_17,
            Model.O3_mini => O3_mini,
            Model.O3_mini_2025_01_31 => O3_mini_2025_01_31,
            Model.Gpt_4o_realtime_preview_2024_10_01 => Gpt_4o_realtime_preview_2024_10_01,
            Model.O1_pro_2025_03_19 => O1_pro_2025_03_19,
            Model.O3_2025_04_16 => O3_2025_04_16,
            Model.O4_mini_2025_04_16 => O4_mini_2025_04_16,
            _ => throw new ArgumentOutOfRangeException(nameof(model), model, null)
        };
    }

    private static string? EnumToString(this BaseModel baseModel)
    {
        return baseModel switch
        {
            BaseModel.Ada => Ada,
            BaseModel.Babbage => Babbage,
            BaseModel.Curie => Curie,
            BaseModel.Davinci => Davinci,
            BaseModel.Cushman => "cushman",
            BaseModel.None => null,
            _ => throw new ArgumentOutOfRangeException(nameof(baseModel), baseModel, null)
        };
    }

    public static string EnumToString(this Subject subject, string? baseModel)
    {
        if (baseModel == null)
        {
            // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
            return subject switch
            {
                Subject.TextEmbedding => "text-embedding",
                Subject.TextModeration => "text-moderation",
                _ => throw new ArgumentOutOfRangeException(nameof(subject), subject, null)
            };
        }

        return string.Format(subject switch
        {
            //{0}-{1}
            Subject.Text => "text-{0}",
            Subject.InstructBeta => "{0}-instruct-beta",
            Subject.SimilarityFast => "{0}-similarity-fast",
            Subject.TextSimilarity => "text-similarity-{0}",
            Subject.TextSearchDocument => "text-search-{0}-doc",
            Subject.TextSearchQuery => "text-search-{0}-query",
            Subject.CodeSearchCode => "code-search-{0}-code",
            Subject.CodeSearchText => "code-search-{0}-text",
            Subject.Code => "code-{0}",
            Subject.CodeEdit => "code-{0}-edit",
            Subject.Edit => "text-{0}-edit",
            Subject.TextEmbedding => "text-embedding-{0}",
            _ => throw new ArgumentOutOfRangeException(nameof(subject), subject, null)
        }, baseModel);
    }
}